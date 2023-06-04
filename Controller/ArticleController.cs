using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class ArticleController
    {
        public List<Article> list()
        {
            List<Article> list = new List<Article>();
            DataAccess dataAccess = new DataAccess();
            try
            {
                dataAccess.setQuery("Select Codigo, Nombre, c.Descripcion Categoria, m.Descripcion Marca, ImagenUrl from ARTICULOS a, CATEGORIAS c, MARCAS m Where IdMarca=m.Id and IdCategoria = c.Id");
                dataAccess.readData();

                while (dataAccess.Reader.Read())
                {
                    Article aux = new Article();
                    aux.Code = (string)dataAccess.Reader["Codigo"];
                    aux.Name = (string)dataAccess.Reader["Nombre"];
                    aux.Category.Name = (string)dataAccess.Reader["Categoria"];
                    aux.Brand.Name = (string)dataAccess.Reader["Marca"];
                    aux.ImageUrl = (string)dataAccess.Reader["ImagenUrl"];
                    list.Add(aux);
                }
                return list;
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
