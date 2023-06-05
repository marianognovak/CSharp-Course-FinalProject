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

namespace View
{
    public partial class AddArticle : Form
    {
        public AddArticle()
        {
            InitializeComponent();
        }

        private void AddArticle_Load(object sender, EventArgs e)
        {
            BrandController brandController = new BrandController();
            try
            {
                cbxBrand.DataSource = brandController.list();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            CategoryController categoryController = new CategoryController();
            try
            {
                cbxCategory.DataSource = categoryController.list();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Article newArticle = new Article();
            ArticleController articleController = new ArticleController();

            try
            {
                newArticle.Code=txtbCode.Text;
                newArticle.Name=txtbName.Text;
                newArticle.Description=txtbDescription.Text;
                newArticle.Brand = (Brand)cbxBrand.SelectedItem;
                newArticle.Category = (Category)cbxCategory.SelectedItem;
                newArticle.ImageUrl=txtbImageUrl.Text;
                newArticle.Price=Decimal.Parse(txtbPrice.Text);

                articleController.addArticle(newArticle);
                MessageBox.Show("Artículo agregado");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
