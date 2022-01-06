using Newtonsoft.Json.Linq;
using RMuseum.Models.Ganjoor.ViewModels;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GanjoorTranslationTagger
{
    public partial class SelectCategory : Form
    {
        public SelectCategory(GanjoorPoetViewModel poet = null)
        {
            InitializeComponent();

            Poet = poet;
        }

        public GanjoorPoetViewModel Poet { private get; set; }

        private async void SelectCategory_Load(object sender, EventArgs e)
        {
            if (Poet == null)
                return;
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();
            using (HttpClient httpClient = new HttpClient())
            {
                var catsApiUrl = $"https://api.ganjoor.net/api/ganjoor/cat/{Poet.RootCatId}?poems=false";
                var response = await httpClient.GetAsync(catsApiUrl);
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    Cursor = Cursors.Default;
                    Enabled = true;
                    MessageBox.Show(await response.Content.ReadAsStringAsync());
                    return;
                }
                response.EnsureSuccessStatusCode();


                var cat = JObject.Parse(await response.Content.ReadAsStringAsync()).ToObject<GanjoorPoetCompleteViewModel>();

                

                foreach (var child in cat.Cat.Children)
                {
                    var node = tree.Nodes.Add(child.Title);
                    node.Tag = child;
                    child.Ancestors = new GanjoorCatViewModel[] { cat.Cat };
                    await FindNodeChildren(node, httpClient, child);
                }

            }
            Cursor = Cursors.Default;
        }

        private async Task FindNodeChildren(TreeNode node, HttpClient httpClient, GanjoorCatViewModel parent)
        {
            var catsApiUrl = $"https://api.ganjoor.net/api/ganjoor/cat/{parent.Id}?poems=false";
            var response = await httpClient.GetAsync(catsApiUrl);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                Cursor = Cursors.Default;
                Enabled = true;
                MessageBox.Show(await response.Content.ReadAsStringAsync());
                return;
            }
            response.EnsureSuccessStatusCode();


            var cat = JObject.Parse(await response.Content.ReadAsStringAsync()).ToObject<GanjoorPoetCompleteViewModel>();
            var ancestors = new List<GanjoorCatViewModel>(parent.Ancestors);
            ancestors.Add(parent);
            foreach (var child in cat.Cat.Children)
            {
                var childNode = node.Nodes.Add(child.Title);
                childNode.Tag = child;
                child.Ancestors = ancestors.ToArray();
                await FindNodeChildren(childNode, httpClient, child);
            }
        }

        public GanjoorCatViewModel SelectedCat { get; set; }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tree.SelectedNode == null)
            {
                MessageBox.Show("لطفا بخش مد نظر را انتخاب کنید.");
                DialogResult = DialogResult.None;
                return;
            }
            SelectedCat = tree.SelectedNode.Tag as GanjoorCatViewModel;
        }

        private void tree_DoubleClick(object sender, EventArgs e)
        {
            if (tree.SelectedNode != null)
            {
                SelectedCat = tree.SelectedNode.Tag as GanjoorCatViewModel;
                DialogResult = DialogResult.OK;
            }
            
        }
    }
}
