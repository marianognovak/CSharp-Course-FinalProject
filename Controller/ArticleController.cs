using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class ArticleController
    {
        public List<Article> listArticles()
        {
            List<Article> articleList = new List<Article>();
            DataAccess dataAccess = new DataAccess();
            try
            {
                dataAccess.setCommandText("Select Codigo, Nombre, c.Descripcion Categoria, m.Descripcion Marca, ImagenUrl, Precio from ARTICULOS a, CATEGORIAS c, MARCAS m Where IdMarca=m.Id and IdCategoria = c.Id");
                dataAccess.readData();

                while (dataAccess.Reader.Read())
                {
                    Article aux = new Article();
                    aux.Code = (string)dataAccess.Reader["Codigo"];
                    aux.Name = (string)dataAccess.Reader["Nombre"];
                    aux.Category.Name = (string)dataAccess.Reader["Categoria"];
                    aux.Brand.Name = (string)dataAccess.Reader["Marca"];
                    if (!(dataAccess.Reader["ImagenUrl"] is DBNull))
                    {
                        aux.ImageUrl = (string)dataAccess.Reader["ImagenUrl"];
                    }
                    aux.Price = (Decimal)dataAccess.Reader["Precio"];
                    articleList.Add(aux);
                }
                return articleList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dataAccess.closeConnection();
            }
        }

        public void addArticle(Article aux)
        {
            DataAccess dataAccess = new DataAccess();

            try
            {
                dataAccess.setCommandText("insert into ARTICULOS values(@code, @name, @description, @brand, @category, @url, @price)");
                dataAccess.setParameters("@code", aux.Code);
                dataAccess.setParameters("@name", aux.Name);
                dataAccess.setParameters("@description", aux.Description);
                dataAccess.setParameters("@brand", aux.Brand.Id);
                dataAccess.setParameters("@category", aux.Category.Id);
                dataAccess.setParameters("@url", aux.ImageUrl);
                dataAccess.setParameters("@price", aux.Price);
                dataAccess.nonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dataAccess.closeConnection();
            }
        }
    }
}
