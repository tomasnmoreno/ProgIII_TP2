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
    public partial class frmPrincipal2 : Form
    {
        public frmPrincipal2()
        {
            InitializeComponent();
        }

        private void frmPrincipal2_Load(object sender, EventArgs e)
        {
            cargar();           
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                dgvArticulos.DataSource = negocio.listar();
                dgvArticulos.Columns["imagenUrl"].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo alta = new frmAgregarArticulo();
            alta.ShowDialog();  
            cargar();
        }
    }
}
