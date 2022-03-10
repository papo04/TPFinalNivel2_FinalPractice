using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class ItemNegocio
    {
        public List<Items> listar()
        {
            List<Items> itemList = new List<Items>();

            DataAccess data = new  DataAccess();
            data.settingQuery("select Codigo, Nombre, a.Descripcion description, ImagenUrl, Precio, m.Descripcion Marca, c.Descripcion Categoria, m.Id marcaid, c.Id categoriaid from ARTICULOS a, MARCAS m, CATEGORIAS c where IdMarca=m.Id and IdCategoria=c.Id");
            data.executeQuery();

            while(data.Reader.Read())
            {
                Items aux = new Items();

                aux.ItemCode = (string)data.Reader["Codigo"];
                aux.Name = (string)data.Reader["Nombre"];
                aux.Description = (string)data.Reader["description"];
                aux.UrlImage = (string)data.Reader["ImagenUrl"];
                aux.Price = (decimal)data.Reader["Precio"];
                aux.CategoryDescription = new Category();
                aux.CategoryDescription.CategoryId = (int)data.Reader["categoriaid"];
                aux.CategoryDescription.CategoryDescription = (string)data.Reader["Categoria"];
                aux.TradeDesciption = new Trademarks();
                aux.TradeDesciption.TradeId = (int)data.Reader["marcaid"];
                aux.TradeDesciption.TradeDescription = (string)data.Reader["Marca"];

                itemList.Add(aux);
            }
            data.closeConnection();

            return itemList;
        }

    }
}
