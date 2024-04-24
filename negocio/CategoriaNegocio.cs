﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class CategoriaNegocio
    {
        public List<CategoriaArticulo> listar()
        {
            List<CategoriaArticulo> listaCategorias = new List<CategoriaArticulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setQuery("select id, descripcion from categorias");
                datos.leer();

                while(datos.Reader.Read())
                {
                    CategoriaArticulo aux = new CategoriaArticulo();
                    aux.id = datos.Reader.GetInt32(0);
                    aux.descripcion = datos.Reader.GetString(1);

                    listaCategorias.Add(aux);
                }

                return listaCategorias;
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