using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace WinForm1
{
    public partial class frmAgregarArticulo : Form
    {
        public frmAgregarArticulo()
        {
            InitializeComponent();
        }

        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                cboCategoria.DataSource = categoriaNegocio.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Articulo newArt = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                newArt.codigo = txtbCodigo.Text;
                newArt.nombre = txtbNombre.Text;
                newArt.descripcion = txtbDescripcion.Text;
                newArt.marca = (Marca)cboMarca.SelectedItem;
                newArt.categoria = (CategoriaArticulo)cboCategoria.SelectedItem;
                newArt.precio = SqlMoney.Parse(txtbPrecio.Text);

                negocio.agregarArticulo(newArt);
                MessageBox.Show("Artículo agregado exitosamente.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
