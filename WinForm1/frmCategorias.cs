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
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private List<CategoriaArticulo> listaCategorias;

        private void cargar()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                listaCategorias = negocio.listar();
                dgvCategorias.DataSource = listaCategorias;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void btnCategoriaSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            frmAgregarCategoria nuevaCategoria = new frmAgregarCategoria();
            nuevaCategoria.ShowDialog();
            cargar();
        }

        private void txtFiltroCategorias_TextChanged(object sender, EventArgs e)
        {
            List<CategoriaArticulo> filtroCategorias;
            string filtro = txtFiltroCategorias.Text;

            if (filtro != "")
            {
                filtroCategorias = listaCategorias.FindAll(a => a.descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                filtroCategorias = listaCategorias;
            }

            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = filtroCategorias;
        }
    }
}
