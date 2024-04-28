using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;

namespace WinForm1
{
    public partial class frmAgregarMarca : Form
    {
        public frmAgregarMarca()
        {
            InitializeComponent();
        }

        private void btnCancelarNuevaMarca_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmarNuevaMarca_Click(object sender, EventArgs e)
        {
            Marca nuevaMarca = new Marca();
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                nuevaMarca.descripcion = txtNuevaMarca.Text;

                negocio.agregarMarca(nuevaMarca);
                MessageBox.Show("Se agregó exitosamente la marca " + nuevaMarca.descripcion);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
    }
}
