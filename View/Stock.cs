using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Controller;

namespace View
{
    public partial class Stock : Form
    {
        private List<Article> articleList;
        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            loadArticles();
        }

        private void loadArticles()
        {
            ArticleController articleController = new ArticleController();
            try
            {
                articleList = articleController.listArticles();
                dgvStock.DataSource = articleList;
                dgvStock.Columns["Description"].Visible = false;
                dgvStock.Columns["ImageUrl"].Visible = false;
                loadImage(articleList[0].ImageUrl);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void loadImage(string image)
        {
            try
            {
                pbArticles.Load(image);
            }
            catch (Exception ex)
            {
                pbArticles.Load("https://www.farmaciaaguacate.es/images/virtuemart/typeless/SinImagen_600x600.jpg");
            }
        }

        private void dgvStock_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Article selected = (Article)dgvStock.CurrentRow.DataBoundItem;
                loadImage(selected.ImageUrl);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(AddArticle)) return;
            }
            AddArticle addArticle = new AddArticle();
            addArticle.ShowDialog();
            loadArticles();
        }
    }
}
