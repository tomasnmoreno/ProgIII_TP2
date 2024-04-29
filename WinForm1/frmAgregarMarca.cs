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
        private Marca marca = null;
        public frmAgregarMarca()
        {
            InitializeComponent();
        }

        public frmAgregarMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
            Text = "Modificar Marca";
        }
        private void btnCancelarNuevaMarca_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmarNuevaMarca_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                if (marca == null) marca = new Marca();
                
                marca.descripcion = txtNuevaMarca.Text;

                if(marca.id != 0)
                {
                    negocio.modificarMarca(marca);
                    MessageBox.Show("Marca modificada exitosamente.");
                    Close();
                }else if(marca.descripcion == ""){
                    MessageBox.Show("Ingrese una marca correcta");
                }
                else
                {
                    negocio.agregarMarca(marca);
                    MessageBox.Show("Se agregó exitosamente la marca " + marca.descripcion);
                    Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void frmAgregarMarca_Load(object sender, EventArgs e)
        {
            try
            {
                if(marca != null) txtNuevaMarca.Text = marca.descripcion;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
