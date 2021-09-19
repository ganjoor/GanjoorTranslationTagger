using Newtonsoft.Json.Linq;
using RMuseum.Models.Ganjoor.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GanjoorTranslationTagger
{
    public partial class SelectPoet : Form
    {
        public SelectPoet()
        {
            InitializeComponent();
        }

        private async void SelectPoet_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();
            using (HttpClient httpClient = new HttpClient())
            {
                var poetsApiUrl = "https://ganjgah.ir/api/ganjoor/poets";
                var response = await httpClient.GetAsync(poetsApiUrl);
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    Cursor = Cursors.Default;
                    Enabled = true;
                    MessageBox.Show(response.ToString());
                    return;
                }
                response.EnsureSuccessStatusCode();
                lst.DataSource = JArray.Parse(await response.Content.ReadAsStringAsync()).ToObject<List<GanjoorPoetViewModel>>();
            }
            Cursor = Cursors.Default;
        }
    }
}
