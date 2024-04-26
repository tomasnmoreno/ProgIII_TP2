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
using System.Reflection;
using System.Data.SqlTypes;

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
                //datos.setQuery("SELECT A.Codigo Codigo, A.Nombre Nombre, A.Descripcion Descripcion, M.Id IdMarca , M.Descripcion Marca, C.Id IdCategoria, C.Descripcion Categoria, A.Precio Precio, I.ImagenUrl ImagenUrl, A.Id FROM ARTICULOS A INNER JOIN MARCAS M ON A.IdMarca = M.Id INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id INNER JOIN IMAGENES I ON I.IdArticulo = A.Id");
                // NUEVA QUERY EN PROCESO, NECESITO UNA SOLA FILA POR CADA CODIGO//
                datos.setQuery("  SELECT A.Codigo Codigo, A.Nombre Nombre, A.Descripcion Descripcion, M.Id IdMarca , M.Descripcion Marca, C.Id IdCategoria, C.Descripcion Categoria, A.Precio Precio, MAX(I.ImagenUrl) as ImagenUrl, A.Id   FROM ARTICULOS A  LEFT JOIN IMAGENES I ON I.IdArticulo = A.Id LEFT JOIN MARCAS M ON A.IdMarca = M.Id  LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id  group by A.Codigo, A.Nombre, A.Descripcion, M.Id, M.Descripcion, C.Id, C.Descripcion, A.Precio, A.Id order by A.Id");
                datos.leer();

                while (datos.Reader.Read())
                {
                    /*
                    Articulo aux = new Articulo();
                    aux.codigo = datos.Reader.GetString(0);
                    aux.nombre = datos.Reader.GetString(1);
                    aux.descripcion = datos.Reader.GetString(2);
                    aux.marca = new Marca();
                    aux.marca.descripcion = datos.Reader.GetString(4);
                    aux.categoria = new CategoriaArticulo();
                    aux.categoria.descripcion = datos.Reader.GetString(6);
                    aux.precio = datos.Reader.GetSqlMoney(7);
                    if (!(datos.Reader["ImagenUrl"] is DBNull))
                    {
                        aux.imagenUrl = datos.Reader.GetString(8);
                    }
                    */
                    Articulo aux = new Articulo();
                    aux.id = (int)datos.Reader["Id"];
                    aux.codigo = (string)datos.Reader["Codigo"];
                    aux.nombre = (string)datos.Reader["Nombre"];
                    aux.descripcion = (string)datos.Reader["Descripcion"];
                    aux.marca = new Marca();
                    aux.marca.id = (int)datos.Reader["IdMarca"];
                    aux.marca.descripcion = (string)datos.Reader["Marca"];
                    aux.categoria = new CategoriaArticulo();
                    if (!(datos.Reader["IdCategoria"] is DBNull))
                    {
                        aux.categoria.id = (int)datos.Reader["IdCategoria"];
                    }
                    if (!(datos.Reader["Categoria"] is DBNull))
                    {
                    aux.categoria.descripcion = (string)datos.Reader["Categoria"];
                    }
                    else{ aux.categoria.descripcion = "N/A"; }
                    aux.precio = datos.Reader.GetSqlMoney(7);
                    //aux.precio = (SqlMoney)datos.Reader["Precio"];
                    if(!(datos.Reader["ImagenUrl"] is DBNull))
                    {
                        aux.imagenUrl = (string)datos.Reader["ImagenUrl"];
                    }

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

        private int ultimoIdArticulo()
        {
            int idUltimo;

            List<Articulo> listaArticulos = new List<Articulo> ();
            listaArticulos = listar();
            idUltimo = listaArticulos.Last().id;
            
            return idUltimo;
        }

        public void agregarArticulo(Articulo newArt)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                int idUltimo = ultimoIdArticulo(); //Ultimo hasta el momento 

                datos.setQuery("insert into articulos (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) values ('" + newArt.codigo + "', '" + newArt.nombre + "', '" + newArt.descripcion + "', @idMarca, @idCategoria, '" + newArt.precio + "')");

                datos.setearParametro("@idMarca", newArt.marca.id);
                datos.setearParametro("@idCategoria", newArt.categoria.id);
                datos.escribir();
                datos.cerrarConexion();

                datos.setQuery("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) values('" + (idUltimo+1) + "', '" + newArt.imagenUrl + "')");
                datos.escribir();

                /*datos.setQuery("DECLARE @IdUltimo INT" + //TOMAS: EN FASE BETA
                    "insert into articulos (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) values ('" + newArt.codigo + "', '" + newArt.nombre + "', '" + newArt.descripcion + "', @idMarca, @idCategoria, '" + newArt.precio + "') SET @IdUltimo = @@IDENTITY " +
                    "INSERT INTO IMAGENES values(@IdUltimo, '" + newArt.imagenUrl + "')"); */
                //NECESITO QUE GUARDE EL REGISTRO CON 'IdArticulo' CON EL {ultimoId + 1}

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

        public void modificarArticulo(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setQuery("UPDATE ARTICULOS SET Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, Precio = @precio where id = @id");

                datos.setearParametro("@codigo", articulo.codigo);
                datos.setearParametro("@nombre", articulo.nombre);
                datos.setearParametro("@descripcion", articulo.descripcion);
                datos.setearParametro("@IdMarca", articulo.marca.id);
                datos.setearParametro("@IdCategoria", articulo.categoria.id);
                datos.setearParametro("@precio", articulo.precio);
                datos.setearParametro("@id", articulo.id);

                datos.escribir();
                datos.cerrarConexion();

                datos.setQuery("UPDATE IMAGENES SET IdArticulo = @IdArticulo, ImagenUrl = @ImagenUrl where IdArticulo = @idWhere");
                datos.setearParametro("IdArticulo", articulo.id);
                datos.setearParametro("@ImagenUrl", articulo.imagenUrl);
                datos.setearParametro("@idWhere", articulo.id ); 
                datos.escribir();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
