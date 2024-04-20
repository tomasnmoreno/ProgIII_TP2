using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbbCategoria.Items.Add("Articulos Limpieza");
            cbbCategoria.Items.Add("Articulos Cocina");
            cbbCategoria.Items.Add("Articulos Decoriacion");
            cbbCategoria.Items.Add("Materiales Construccion");
            cbbCategoria.Items.Add("Alimentos");
            cbbCategoria.Items.Add("Bazar");
        }

        private void btContinuar_Click(object sender, EventArgs e)
        {
            Articulo art = new Articulo();
            /*
            //copiar contenido txtbCodigo
            art.codigo = txtbCodigo.Text;
            //copiar contenido txtbNombre
            art.nombre = txtbNombre.Text;
            //copiar contenido txtbDescripcion
            art.descripcion = txtbDescripcion.Text;
            //copiar contenido txtbMarca
            //art.marca = cbbMarca.Text;
            //copiar contenido txtbPrecio
            art.precio = float.Parse(txtbPrecio.Text);
            //copiar contenido cbbCategoria
            //art.categoria = ;
            //guardar imagen de articulo de pbImagenArticulo
            */
        }
    }
}
