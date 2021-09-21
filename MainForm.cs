using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RMuseum.Models.Ganjoor;
using RMuseum.Models.Ganjoor.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
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
                var languagesApiUrl = "https://ganjgah.ir/api/translations/languages";
                var response = await httpClient.GetAsync(languagesApiUrl);
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    Cursor = Cursors.Default;
                    Enabled = true;
                    MessageBox.Show(response.ToString());
                    return;
                }
                response.EnsureSuccessStatusCode();
                cmbLanguage.DataSource = JArray.Parse(await response.Content.ReadAsStringAsync()).ToObject<List<GanjoorLanguage>>();
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
                var loginUrl = "https://ganjgah.ir/api/users/login";
                var response = await httpClient.PostAsync(loginUrl, stringContent);
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    Cursor = Cursors.Default;
                    Enabled = true;
                    MessageBox.Show(response.ToString());
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

        
    }
}
