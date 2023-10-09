using GanjoorTranslationTagger.ImportedViewModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RMuseum.Models.Ganjoor;
using RMuseum.Models.Ganjoor.ViewModels;
using RMuseum.Services.Implementation.ImportedFromDesktopGanjoor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;

namespace GanjoorTranslationTagger
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            txtEmail.Text = Properties.Settings.Default.Email;
            if (!string.IsNullOrEmpty(Properties.Settings.Default.MuseumToken))
                lblLoginStatus.Text = "شما وارد سیستم شده‌اید!";
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();
            using (HttpClient httpClient = new HttpClient())
            {
                var languagesApiUrl = "https://api.ganjoor.net/api/translations/languages";
                var response = await httpClient.GetAsync(languagesApiUrl);
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    Cursor = Cursors.Default;
                    Enabled = true;
                    MessageBox.Show(await response.Content.ReadAsStringAsync());
                    return;
                }
                response.EnsureSuccessStatusCode();
                cmbLanguage.DataSource = JArray.Parse(await response.Content.ReadAsStringAsync()).ToObject<List<GanjoorLanguage>>();
                cmbLanguage.SelectedIndex = cmbLanguage.Items.Count - 1;
            }
            Cursor = Cursors.Default;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Enabled = false;
            Application.DoEvents();

            DialogResult = DialogResult.None;
            LoginViewModel model = new LoginViewModel()
            {
                Username = txtEmail.Text,
                Password = txtPassword.Text,
                ClientAppName = "Ganjoor Translation Tagger",
                Language = "fa-IR"
            };

            using (HttpClient httpClient = new HttpClient())
            {
                var stringContent = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
                var loginUrl = "https://api.ganjoor.net/api/users/login";
                var response = await httpClient.PostAsync(loginUrl, stringContent);
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    Cursor = Cursors.Default;
                    Enabled = true;
                    MessageBox.Show(await response.Content.ReadAsStringAsync());
                    return;
                }
                response.EnsureSuccessStatusCode();

                var result = JObject.Parse(await response.Content.ReadAsStringAsync());
                Properties.Settings.Default.Email = txtEmail.Text;
                Properties.Settings.Default.MuseumToken = result["token"].ToString();
                Properties.Settings.Default.SessionId = Guid.Parse(result["sessionId"].ToString());
                Properties.Settings.Default.UserId = Guid.Parse(result["user"]["id"].ToString());
                Properties.Settings.Default.Save();
            }

            Enabled = true;
            Cursor = Cursors.Default;
            DialogResult = DialogResult.OK;
        }

        private void btnLanguages_Click(object sender, EventArgs e)
        {
            Process.Start("https://ganjoor.net/User/Languages");
        }

        private void btnSelectCategory_Click(object sender, EventArgs e)
        {
            using(SelectPoet poetsDialog = new SelectPoet())
            {
                if(poetsDialog.ShowDialog(this) == DialogResult.OK)
                {
                    using(SelectCategory dlg = new SelectCategory(poetsDialog.SelectedPoet))
                        if(dlg.ShowDialog(this) == DialogResult.OK)
                        {
                            _selectedCat = dlg.SelectedCat;
                            lblSelectedCat.Text = _selectedCat.ToString();
                        }
                }
            }
        }

        private GanjoorCatViewModel _selectedCat = null;

        private async void btnStartTranslating_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.MuseumToken))
            {
                MessageBox.Show("لطفاً وارد سیستم شوید.");
                return;
            }

            if (_selectedCat == null)
            {
                MessageBox.Show("لطفاً بخش مد نظر را انتخاب کنید.");
                return;
            }

            if(cmbLanguage.SelectedItem == null)
            {
                MessageBox.Show("لطفاً زبان مد نظر را انتخاب کنید.");
                return;
            }

            var language = cmbLanguage.SelectedItem as GanjoorLanguage;

            if (MessageBox.Show($"آیا از برگردان {_selectedCat} به {cmbLanguage.SelectedItem} اطمینان دارید؟", "تأییدیه", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            Cursor = Cursors.WaitCursor;
            Application.DoEvents();
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Properties.Settings.Default.MuseumToken);

                var catsApiUrl = $"https://api.ganjoor.net/api/ganjoor/cat/{_selectedCat.Id}?poems=true";
                var response = await httpClient.GetAsync(catsApiUrl);
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    Cursor = Cursors.Default;
                    Enabled = true;
                    MessageBox.Show(await response.Content.ReadAsStringAsync());
                    return;
                }
                response.EnsureSuccessStatusCode();


                var catWithListOfPoems = JObject.Parse(await response.Content.ReadAsStringAsync()).ToObject<GanjoorPoetCompleteViewModel>();

                foreach(var poem in catWithListOfPoems.Cat.Poems)
                {
                    var responsePoem = await httpClient.GetAsync($"https://api.ganjoor.net/api/ganjoor/poem/{poem.Id}?verseDetails=true&catInfo=true&rhymes=false&recitations=false&images=false&songs=false&comments=false&navigation=true");
                    if (!responsePoem.IsSuccessStatusCode)
                    {
                        Cursor = Cursors.Default;
                        Enabled = true;
                        MessageBox.Show(await response.Content.ReadAsStringAsync());
                        return;
                    }

                    responsePoem.EnsureSuccessStatusCode();

                    var poemWithVerses = JsonConvert.DeserializeObject<GanjoorPoemCompleteViewModel>(await responsePoem.Content.ReadAsStringAsync());

                    List<GanjoorVerseTranslationViewModel> verses = new List<GanjoorVerseTranslationViewModel>();
                    foreach (GanjoorVerseViewModel v in poemWithVerses.Verses)
                    {
                        verses.Add
                               (
                               new GanjoorVerseTranslationViewModel()
                               {
                                   Verse = new GanjoorVerseViewModel() { VOrder = v.VOrder },
                                   TText = GPersianTextSync.Farglisize(v.Text)
                               }
                               );
                    }

                    var translation = new GanjoorPoemTranslationViewModel()
                    {
                        Language = language,
                        PoemId = poemWithVerses.Id,
                        Title = GPersianTextSync.Farglisize(poemWithVerses.Title),
                        Published = false,
                        Description = "برچسب‌گذاری خودکار توسط برنامهٔ آزمایشی",
                        TranslatedVerses = verses.ToArray()
                    };

                    HttpResponseMessage responseTranslation = await httpClient.PostAsync($"https://api.ganjoor.net/api/translations",
                        new StringContent(JsonConvert.SerializeObject(translation),
                        Encoding.UTF8,
                        "application/json"));
                    if (!responseTranslation.IsSuccessStatusCode)
                    {
                        Cursor = Cursors.Default;
                        Enabled = true;
                        MessageBox.Show(await responseTranslation.Content.ReadAsStringAsync());
                        return;
                    }
                }
                

            }
            Cursor = Cursors.Default;

            MessageBox.Show("انجام شد.");
        }

        private async void btnBackup_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    Cursor = Cursors.WaitCursor;
                    Application.DoEvents();
                    using (HttpClient httpClient = new HttpClient())
                    {
                        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Properties.Settings.Default.MuseumToken);
                        int pageNumber = 1;
                        int totalCount = 1;
                        
                        do
                        {
                            var translationsUrl = $"https://api.ganjoor.net/api/translations/all/{(cmbLanguage.SelectedItem as GanjoorLanguage).Id}?PageNumber=${pageNumber}&PageSize=1000";
                            var responseTranslatons = await httpClient.GetAsync(translationsUrl);
                            if (responseTranslatons.StatusCode != HttpStatusCode.OK)
                            {
                                Cursor = Cursors.Default;
                                Enabled = true;
                                MessageBox.Show(await responseTranslatons.Content.ReadAsStringAsync());
                                return;
                            }
                            responseTranslatons.EnsureSuccessStatusCode();
                            var translations = JArray.Parse(await responseTranslatons.Content.ReadAsStringAsync()).ToObject<List<GanjoorPoemTranslationViewModel>>();
                            if(translations.Count == 0)
                            {
                                break;
                            }

                            string paginationMetadataJsonValue = responseTranslatons.Headers.GetValues("paging-headers").FirstOrDefault();

                            if(totalCount == 1)
                            {
                                if (!string.IsNullOrEmpty(paginationMetadataJsonValue))
                                {
                                    var meta = JsonConvert.DeserializeObject<PaginationMetadata>(paginationMetadataJsonValue);
                                    totalCount = meta.totalCount;
                                    prgrss.Value = 0;
                                    prgrss.Maximum = totalCount;
                                }
                            }
                            

                            foreach (var translation in translations)
                            {
                                prgrss.Value++;
                                Application.DoEvents();
                            }

                        }
                        while (true);
                                               
                    }
                    Cursor = Cursors.Default;
                }
            }
        }
    }
}
