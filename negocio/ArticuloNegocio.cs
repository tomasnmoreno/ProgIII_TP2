using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.CodeDom;
using dominio;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> listaArticulos = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();  

            try
            {
                datos.setQuery("SELECT A.Codigo, A.Nombre, A.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria, A.Precio FROM ARTICULOS A INNER JOIN MARCAS M ON A.IdMarca = M.Id INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id");
                datos.leer();

                while(datos.Reader.Read())
                {
                    Articulo aux = new Articulo();
                    aux.codigo = datos.Reader.GetString(0);
                    aux.nombre = datos.Reader.GetString(1);
                    aux.descripcion = datos.Reader.GetString(2);
                    aux.marca = new Marca();
                    aux.marca.descripcion = datos.Reader.GetString(3);
                    aux.categoria = new CategoriaArticulo();
                    aux.categoria.descripcion = datos.Reader.GetString(4);
                    aux.precio = datos.Reader.GetSqlMoney(5);

                    listaArticulos.Add(aux);
                }

                return listaArticulos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
            
        }

        public void agregarArticulo(Articulo newArt)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setQuery("insert into articulos (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) values ('" + newArt.codigo + "', '" + newArt.nombre + "', '" + newArt.descripcion + "', @idMarca, @idCategoria, '" + newArt.precio + "')");
                datos.setearParametro("@idMarca", newArt.marca.id);
                datos.setearParametro("@idCategoria", newArt.categoria.id);
                datos.escribir();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
