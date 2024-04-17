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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cboMarca.Items.Add (" Listar marcas");
            cboMarca.Items.Add (" Agregar marca");
            cboMarca.Items.Add (" Eliminar marca ");
            cboMarca.Items.Add (" Modificar descripción");

            cboCategoria.Items.Add("Listar categorías");
            cboCategoria.Items.Add("Agregar categorías");
            cboCategoria.Items.Add("Eliminar categorías");
            cboCategoria.Items.Add("Modificar descripción");
            
            

        }

        private void AgregarArticulo_Click(object sender, EventArgs e)
        {
            Form1 AgregarArticulo = new Form1();
            AgregarArticulo.ShowDialog();

        }

        private void ModificarArticulo_Click(object sender, EventArgs e)
        {
            frmModificarArticulo ModificarArticulo = new frmModificarArticulo();
            ModificarArticulo.ShowDialog();
        }

        private void BusquedaArticulos_Click(object sender, EventArgs e)
        {
            frmBusquedaArticulo BusquedaArticulos = new frmBusquedaArticulo();
            BusquedaArticulos.ShowDialog();
        }
    }
}
