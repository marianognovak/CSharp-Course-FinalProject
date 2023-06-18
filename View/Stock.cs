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
            MinimumSize = Size;
            loadArticles();
            loadComboBox();
        }

        private void dgvStock_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Article selectedArticle = (Article)dgvStock.CurrentRow.DataBoundItem;
                loadImage(selectedArticle.ImageUrl);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnSeeDetails_Click(object sender, EventArgs e)
        {
            if (!isRowSelected())
            {
                MessageBox.Show("No hay un artículo seleccionado para ver en detalle.");
                return;
            }

            Article selectedArticle = (Article)dgvStock.CurrentRow.DataBoundItem;
            ArticleDetails articleDetails = new ArticleDetails(selectedArticle);
            articleDetails.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddArticle addArticle = new AddArticle();
            addArticle.ShowDialog();
            if(addArticle.hasToRefresh) loadArticles();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (!isRowSelected())
            {
                MessageBox.Show("No hay un artículo seleccionado para modificar.");
                return;
            }

            Article articleToModify = (Article)dgvStock.CurrentRow.DataBoundItem;
            AddArticle addArticle = new AddArticle(articleToModify);
            addArticle.ShowDialog();
            if(addArticle.hasToRefresh) loadArticles();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!isRowSelected())
            {
                MessageBox.Show("No hay un artículo seleccionado para eliminar.");
                return;
            }

            DialogResult delete = MessageBox.Show("¿Seguro de que quieres eliminar el artículo? El mismo no podrá ser recuperado.", "Eliminar artículo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (delete == DialogResult.Yes)
            {
                Article articleToDelete = (Article)dgvStock.CurrentRow.DataBoundItem;
                ArticleController articleController = new ArticleController();
                articleController.deleteArticle(articleToDelete);
                loadArticles();
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            ArticleController articleController = new ArticleController();
            if (string.IsNullOrEmpty(txtbFilter.Text)&&txtbFilter.Enabled)
            {
                MessageBox.Show("El filtro está vacío.");
                return;
            }
            if (cbxField.Text == "Id" || cbxField.Text == "Precio")
            {
                if (!isNumeric(txtbFilter.Text))
                {
                    MessageBox.Show("El campo '"+cbxField.Text+"' solo puede recibir números.");
                    return;
                }
            }
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
            loadArticles();
            cbxField.SelectedIndex = 0;
            cbxCriterion.SelectedIndex=0;
            txtbFilter.Text = "";
        }

        private void cbxField_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cbxField.SelectedItem.ToString();

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
                cbxCriterion.Items.Clear();

                if (selected == "Marca")
                {
                    BrandController brandController = new BrandController();
                    List<Brand> brandList = brandController.list();

                    foreach (Brand brand in brandList)
                    {
                        cbxCriterion.Items.Add(brand.Name); 
                    }
                }
                else
                {
                    CategoryController categoryController = new CategoryController();
                    List<Category> categoryList = categoryController.list();

                    foreach (Category category in categoryList)
                    {
                        cbxCriterion.Items.Add(category.Name);
                    }
                }
            }
            cbxCriterion.SelectedIndex = 0;
        }

        public void loadArticles()
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
            catch (Exception)
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

        private bool isRowSelected()
        {
            if (dgvStock.SelectedRows.Count < 1)
            {
                return false;
            }
            return true;
        }

        private bool isNumeric(string filterTextBox)
        {
            foreach (char item in filterTextBox)
            {
                if (!char.IsNumber(item))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
