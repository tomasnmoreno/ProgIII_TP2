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
        public frmAgregarCategoria()
        {
            InitializeComponent();
        }

        private void btnConfirmarNuevaCategoria_Click(object sender, EventArgs e)
        {
            CategoriaArticulo nuevaCategoria = new CategoriaArticulo();
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                nuevaCategoria.descripcion = txtNuevaCategoria.Text;

                negocio.agregarCategoria(nuevaCategoria);
                MessageBox.Show("Se agregó exitosamente la categoría " + nuevaCategoria.descripcion);
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
    }
}
