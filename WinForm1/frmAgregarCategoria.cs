using dominio;
using negocio;
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
    public partial class frmAgregarCategoria : Form
    {
        private CategoriaArticulo categoria = null;
        public frmAgregarCategoria()
        {
            InitializeComponent();
        }
        public frmAgregarCategoria(CategoriaArticulo categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            Text = "Modificar Categoría";
        }

        private void btnConfirmarNuevaCategoria_Click(object sender, EventArgs e)
        {           
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                if (categoria == null) categoria = new CategoriaArticulo();

                categoria.descripcion = txtNuevaCategoria.Text;

                if(categoria.id != 0)
                {
                    negocio.modificarCategoria(categoria);
                    MessageBox.Show("Categoría modificada exitosamente.");
                }
                else
                {
                    negocio.agregarCategoria(categoria);
                    MessageBox.Show("Se agregó exitosamente la categoría " + categoria.descripcion);
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void btnCancelarNuevaCategoria_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAgregarCategoria_Load(object sender, EventArgs e)
        {
            try
            {
                if(categoria != null) txtNuevaCategoria.Text = categoria.descripcion;             
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
