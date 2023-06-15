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

        private void loadComboBox()
        {
            cbxField.Items.Add("Id");
            cbxField.Items.Add("Código");
            cbxField.Items.Add("Nombre");
            cbxField.Items.Add("Marca");
            cbxField.Items.Add("Categoría");
            cbxField.Items.Add("Precio");
            cbxField.SelectedIndex = 0;
            cbxCriterion.SelectedIndex = 0;
        }



        private void Stock_Load(object sender, EventArgs e)
        {
            MinimumSize = Size;
            loadArticles();
            loadComboBox();
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

        private void btnModify_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(AddArticle)) return;
            }
            AddArticle addArticle = new AddArticle((Article)dgvStock.CurrentRow.DataBoundItem);
            addArticle.ShowDialog();
            loadArticles();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show("¿Seguro de que quieres eliminar el artículo? No podrá ser recuperado", "Eliminar artículo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (delete == DialogResult.Yes)
            {
                ArticleController articleController = new ArticleController();
                articleController.deleteArticle((Article)dgvStock.CurrentRow.DataBoundItem);
                loadArticles();
            }
        }

        private void cbxField_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cbxField.SelectedItem.ToString();
            BrandController brandController = new BrandController();
            CategoryController categoryController = new CategoryController();
            List<Brand> brandList = brandController.list();
            List<Category> categoryList = categoryController.list();

            if (selected == "Id" || selected == "Precio")
            {
                txtbFilter.Enabled = true;
                cbxCriterion.Items.Clear();
                cbxCriterion.Items.Add("Menor a");
                cbxCriterion.Items.Add("Igual a");
                cbxCriterion.Items.Add("Mayor a");
            }
            else if (selected == "Código" || selected == "Nombre")
            {
                txtbFilter.Enabled = true;
                cbxCriterion.Items.Clear();
                cbxCriterion.Items.Add("Empieza con");
                cbxCriterion.Items.Add("Contiene");
                cbxCriterion.Items.Add("Termina con");
            }
            else{
                txtbFilter.Clear();
                txtbFilter.Enabled = false;
                if(selected == "Marca")
                {
                    cbxCriterion.Items.Clear();
                    foreach (Brand brand in brandList)
                    {
                        cbxCriterion.Items.Add(brand.Name);
                    }
                }
                if (selected == "Categoría")
                {
                    cbxCriterion.Items.Clear();
                    foreach (Category category in categoryList)
                    {
                        cbxCriterion.Items.Add(category.Name);
                    }
                }
            }
            cbxCriterion.SelectedIndex = 0;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            ArticleController articleController = new ArticleController();
            try
            {
                dgvStock.DataSource = articleController.filterSearch(cbxField.SelectedItem.ToString(), cbxCriterion.SelectedItem.ToString(), txtbFilter.Text);              
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            DialogResult resetFilters = MessageBox.Show("¿Seguro de que quieres reiniciar los filtros?", "Reiniciar filtros", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resetFilters == DialogResult.Yes)
            {
                cbxField.SelectedIndex = 0;
                cbxCriterion.SelectedIndex = 0;
                txtbFilter.Text = "";
                loadArticles();
            }
        }
    }
}
