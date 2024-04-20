using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.CodeDom;
using System.Windows.Forms;

namespace WinForm1
{
    internal class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> listaArticulo = new List<Articulo>();
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            try
            {
                conn.ConnectionString = "server=DESKTOP-NVCUBBL\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio from ARTICULOS";
                cmd.Connection = conn;

                conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Articulo aux = new Articulo();
                    //aux.codigo = (int)reader["Codigo"];
                    aux.codigo = reader.GetString(0);
                    aux.nombre = reader.GetString(1);
                    aux.descripcion = reader.GetString(2);
                    aux.marca = reader.GetInt32(3);
                    aux.categoria = reader.GetInt32(4);
                    aux.precio = reader.GetSqlMoney(5);

                    listaArticulo.Add(aux);
                }

                //conn.Close(); 
                return listaArticulo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                throw ex;
            }
            finally
            {
                conn.Close ();
            }
            
        }
    }
}
