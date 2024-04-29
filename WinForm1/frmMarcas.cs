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
    public partial class frmMarcas : Form
    {
        private Marca marca = null;
        public frmMarcas()
        {
            InitializeComponent();
        }

        private List<Marca> listaMarcas;

        private void cargar()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                listaMarcas = negocio.listar();
                dgvMarcas.DataSource = listaMarcas;
                dgvMarcas.Columns["id"].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void frmMarcas_Load(object sender, EventArgs e)
        {
            cargar();
            
        }
         private void btnMarcasSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            frmAgregarMarca nuevaMarca = new frmAgregarMarca();
            nuevaMarca.ShowDialog();
            cargar();
        }
        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            Marca seleccionada;
            seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            frmAgregarMarca modificarMarca = new frmAgregarMarca(seleccionada);
            modificarMarca.ShowDialog();
            cargar();
        }
        private void txtFiltroMarcas_TextChanged(object sender, EventArgs e)
        {
            List<Marca> filtroMarcas;
            string filtro = txtFiltroMarcas.Text;

            if (filtro != "")
            {
                filtroMarcas = listaMarcas.FindAll(a => a.descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                filtroMarcas = listaMarcas;
            }

            dgvMarcas.DataSource = null;
            dgvMarcas.DataSource = filtroMarcas;
            dgvMarcas.Columns["id"].Visible = false;
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            Marca seleccionada;

            try
            {
                seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar la marca " + seleccionada.descripcion + "?","Eliminar Marca", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    negocio.eliminarMarca(seleccionada.id);
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
