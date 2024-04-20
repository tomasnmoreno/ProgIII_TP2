using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm1
{
    internal class Articulo
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public Marca marca { get; set; }
        public CategoriaArticulo categoria { get; set; }
        public string imagenUrl { get; set; }

        List <string> listaImagenes = new List<string>();
        public float precio { get; set; }
    }


}
