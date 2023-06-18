using Controller;
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
using System.Data.SqlTypes;
using static System.Net.Mime.MediaTypeNames;

namespace View
{
    public partial class AddArticle : Form
    {
        private Article article = null;
        public bool hasToRefresh { get; set; }
        public AddArticle()
        {
            InitializeComponent();
        }

        public AddArticle(Article article)
        {
            InitializeComponent();
            this.article = article;
            Text = "Modificar artículo";
        }

        private void AddArticle_Load(object sender, EventArgs e)
        {
            hasToRefresh = false;
            BrandController brandController = new BrandController();
            CategoryController categoryController = new CategoryController();
            try
            {
                cbxBrand.DataSource = brandController.list();
                cbxBrand.ValueMember = "Id";
                cbxBrand.DisplayMember = "Name";
                cbxCategory.DataSource = categoryController.list();
                cbxCategory.ValueMember = "Id";
                cbxCategory.DisplayMember = "Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (article!=null)
            {
                txtbCode.Text = article.Code;
                txtbName.Text = article.Name;
                txtbDescription.Text = article.Description;
                txtbImageUrl.Text = article.ImageUrl;
                loadImage(article.ImageUrl);
                txtbPrice.Text = article.Price.ToString();
                cbxBrand.SelectedValue = article.Brand.Id;
                cbxCategory.SelectedValue = article.Category.Id;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (isCompleted())
            {
                hasToRefresh = true;
                ArticleController articleController = new ArticleController();
                try
                {
                    if (article == null) article = new Article();
                    article.Code = txtbCode.Text;
                    article.Name = txtbName.Text;
                    article.Description = txtbDescription.Text;
                    article.Brand = (Brand)cbxBrand.SelectedItem;
                    article.Category = (Category)cbxCategory.SelectedItem;
                    article.ImageUrl = txtbImageUrl.Text;
                    article.Price = Decimal.Parse(txtbPrice.Text);

                    if (article.Id != 0)
                    {
                        articleController.modifyArticle(article);
                        MessageBox.Show("Artículo modificado.");
                    }
                    else
                    {
                        articleController.addArticle(article);
                        MessageBox.Show("Artículo agregado.");
                    }
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else MessageBox.Show("No se han completado todos los campos. Por favor, vuelva a intentarlo.");
        }

        private void txtbImageUrl_Leave(object sender, EventArgs e) => loadImage(txtbImageUrl.Text);

        private void loadImage(string image)
        {
            try
            {
                pbAdd.Load(image);
            }
            catch (Exception)
            {
                pbAdd.Load("https://www.farmaciaaguacate.es/images/virtuemart/typeless/SinImagen_600x600.jpg");
            }
        }

        private bool isCompleted()
        {
            bool isCompleted = true;
            if (!labelColor(lblCode, txtbCode)) isCompleted = false;
            if (!labelColor(lblName, txtbName)) isCompleted = false;
            if (!labelColor(lblDescription, txtbDescription)) isCompleted = false;
            if (!labelColor(lblImageUrl, txtbImageUrl)) isCompleted = false;
            if (!labelColor(lblPrice, txtbPrice)) isCompleted = false;
            return isCompleted;
        }

        private bool labelColor(Label label, TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                label.ForeColor = Color.Red;
                return false;
            }
            else
            {
                label.ForeColor = Color.Black;
                return true;
            }
        }
    }
}
