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

        }

        /*load*/

        //ArticleController articleController = new ArticleController();
        //    try
        //    {
        //        articleList = articleController.list();
        //        dgvStock.DataSource = articleList;
        //        dgvStock.Columns["Description"].Visible = false;
        //        dgvStock.Columns["ImageUrl"].Visible = false;
        //        pbArticles.Load(articleList[0].ImageUrl);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
   
        /*addbutton*/

        //foreach (var item in Application.OpenForms)
        //{
        //    if (item.GetType() == typeof(AddArticle)) return;
        //}
        //AddArticle addArticle = new AddArticle();
        //addArticle.ShowDialog();

        /*selectionchanged*/
         
        //try
        //{
        //    Article selected = (Article)dgvStock.CurrentRow.DataBoundItem;
        //    pbArticles.Load(selected.ImageUrl);
        //}
        //catch (Exception ex)
        //{
        //    throw ex;
        //}

    }
}
