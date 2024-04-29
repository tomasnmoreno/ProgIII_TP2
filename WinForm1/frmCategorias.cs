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
                dgvCategorias.Columns["id"].Visible = false;
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
        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            CategoriaArticulo seleccionada;
            seleccionada = (CategoriaArticulo)dgvCategorias.CurrentRow.DataBoundItem;
            frmAgregarCategoria modificarCategoria = new frmAgregarCategoria(seleccionada);
            modificarCategoria.ShowDialog();
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
            dgvCategorias.Columns["id"].Visible = false;
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            CategoriaArticulo seleccionada;

            try
            {
                seleccionada = (CategoriaArticulo)dgvCategorias.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar la categoría " + seleccionada.descripcion + "?", "Eliminar Categoría", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    negocio.eliminarCategoria(seleccionada.id);
                }
                cargar();
            }
            catch (Exception ex)
            {
                    
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
