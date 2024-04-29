using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace WinForm1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private List<Articulo> listaArticulos; //para usar en vez de 'datos.listar()'

        private void frmPrincipal2_Load(object sender, EventArgs e)
        {
            cargar();

            if (dgvArticulos.Rows.Count > 0)
            {
                dgvArticulos.Rows[0].Selected = true;
                dgvArticulos.CurrentCell = dgvArticulos.Rows[0].Cells[1];
                dgvArticulos.Refresh();
                /*dgvArticulos.Rows[0].Selected = true;
                dgvArticulos.CurrentCell = dgvArticulos.Rows[0].Cells[0]; // Establecer la celda actual en la primera fila
                dgvArticulos.FirstDisplayedScrollingRowIndex = 0; // Desplazar el DataGridView a la fila seleccionada*/
            }
            cboBusquedaCampo.Items.Add("Marca");
            cboBusquedaCampo.Items.Add("Categoría");
            cboBusquedaCampo.Items.Add("Precio");
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listar();
                dgvArticulos.DataSource = listaArticulos;
                //pbxArticulo.Load(listaArticulos[0].imagenUrl);

                ocultarColumnas();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["imagenUrl"].Visible = false;
            dgvArticulos.Columns["id"].Visible = false;
            dgvArticulos.Columns["imagenUrl"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo alta = new frmAgregarArticulo();
            alta.ShowDialog();  
            cargar(); //para que vuelva a cargar la lista al salir de Agregar Articulo
        }

        private void cargarImagen (string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pbxArticulo.Load("https://t3.ftcdn.net/jpg/02/48/42/64/360_F_248426448_NVKLywWqArG2ADUxDq6QprtIzsF82dMF.jpg");
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.imagenUrl);
            }      
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (listaArticulos.Any())
            {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAgregarArticulo modificar = new frmAgregarArticulo(seleccionado);
            modificar.ShowDialog();
            cargar();
            }
            else
            {
                MessageBox.Show("No existen artículos para modificar.");
            }
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (listaArticulos.Any())
            {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAgregarArticulo detalle = new frmAgregarArticulo(seleccionado, 1);
            detalle.ShowDialog();
            cargar();
            }
            else
            {
                MessageBox.Show("No existen artículos para ver el detalle.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
            {

                ArticuloNegocio negocio = new ArticuloNegocio();
                Articulo selecionado;
            if (listaArticulos.Any())
            {
                try
                {
                    DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea eliminar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        selecionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                        negocio.eliminar(selecionado.id);
                        cargar();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("No existen artículos para eliminar");
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> filtroArticulos;
            string filtro = txtBusqueda.Text;

            if (filtro != "")
            {
                filtroArticulos = listaArticulos.FindAll(a => a.codigo.ToUpper().Contains(filtro.ToUpper()) || a.nombre.ToUpper().Contains(filtro.ToUpper()) || a.descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                filtroArticulos = listaArticulos;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = filtroArticulos;
            ocultarColumnas();
        }

        private void cboBusquedaCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboBusquedaCampo.SelectedItem.ToString();
            if(opcion == "Precio")
            {
                cboBusquedaCriterio.Items.Clear();
                cboBusquedaCriterio.Items.Add("Mayor que");
                cboBusquedaCriterio.Items.Add("Menor que");
                cboBusquedaCriterio.Items.Add("Igual a");
            }else
            {
                cboBusquedaCriterio.Items.Clear();
                cboBusquedaCriterio.Items.Add("Comienza con");
                cboBusquedaCriterio.Items.Add("Termina con");
                cboBusquedaCriterio.Items.Add("Contiene");
            }
            
        }

        private bool validarFiltro()
        {
            if(cboBusquedaCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un campo para filtrar.");
                return true;
            }
            if(cboBusquedaCriterio.SelectedIndex <0)
            {
                MessageBox.Show("Seleccione un criterio para filtrar.");
                return true;
            }
            if(cboBusquedaCampo.SelectedItem.ToString() == "Precio")
            {
                if(!(soloNumeros(txtFiltroBusqueda.Text)) || txtFiltroBusqueda.Text == "")
                {
                    MessageBox.Show("Seleccione un precio correcto.");
                    return true;
                }
            }
            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                {
                    return false;
                }
            }
            return true;
        }

        private void btnBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                //AGREGAR VALIDACION ANTE UNA BUSQUEDA VACIA
                if (validarFiltro())
                {
                    return;
                }
                string campo = cboBusquedaCampo.SelectedItem.ToString();
                string criterio = cboBusquedaCriterio.SelectedItem.ToString();
                string filtro = txtFiltroBusqueda.Text;
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            frmMarcas marcas = new frmMarcas();
            marcas.ShowDialog();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias categorias = new frmCategorias();
            categorias.ShowDialog();
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            cargar();
        }
    }

}
