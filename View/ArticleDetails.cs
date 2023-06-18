using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class ArticleDetails : Form
    {
        private Article articleToInspect;
        public ArticleDetails(Article article)
        {
            InitializeComponent();
            articleToInspect = article;
        }

        private void ArticleDetails_Load(object sender, EventArgs e)
        {
            txtbCode.Text = articleToInspect.Code;
            txtbName.Text = articleToInspect.Name;
            txtbDescription.Text = articleToInspect.Description;
            txtbBrand.Text = articleToInspect.Brand.ToString();
            txtbCategory.Text = articleToInspect.Category.ToString();
            txtbImageUrl.Text = articleToInspect.ImageUrl;
            txtbPrice.Text = articleToInspect.Price.ToString();
            loadImage(articleToInspect.ImageUrl);
        }

        private void loadImage(string image)
        {
            try
            {
                pbDetails.Load(image);
            }
            catch (Exception)
            {
                pbDetails.Load("https://www.farmaciaaguacate.es/images/virtuemart/typeless/SinImagen_600x600.jpg");
            }
        }
    }
}
