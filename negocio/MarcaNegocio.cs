﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
            List<Marca> listaMarcas = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setQuery("select id, descripcion from marcas");
                datos.leer();

                while(datos.Reader.Read())
                {
                    Marca aux = new Marca();
                    aux.id = datos.Reader.GetInt32(0);
                    aux.descripcion = datos.Reader.GetString(1);

                    listaMarcas.Add(aux);
                }

                return listaMarcas;
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