using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace WinForm1
{
    public partial class frmAgregarArticulo : Form
    {
        private Articulo articulo = null;

        private List<Imagen> listaImagenes = new List<Imagen>();

        public frmAgregarArticulo()
        {
            InitializeComponent();
        }

        public frmAgregarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
            lblTiuloArticulos.Text = "Modificar Articulo";
        }

        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            Imagen imagenSelecccionada = new Imagen();

            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "id"; //para que cargue los listas despl de Marca. Separo en Value(que campo mira del obj marca)
                cboMarca.DisplayMember = "descripcion"; // Separo Display = que campo muestra del objeto marca
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "id";
                cboCategoria.DisplayMember = "descripcion";


                if (articulo != null)
                {
                    
                    txtbCodigo.Text = articulo.codigo;
                    txtbNombre.Text = articulo.nombre;
                    txtbDescripcion.Text = articulo.descripcion;
                    txtbPrecio.Text = articulo.precio.ToString();
                    //txtbImagenUrl.Text = articulo.imagenUrl; //LO COMENTO PORQUE QUIERO QUE ME APAREZCA VACIO EL TXTB DE LA URL
                    //cargarImagen(articulo.imagenUrl); //no va mas porq ahora la imagen la obtengo de la ListaImagenes <currentRow>
                    cboMarca.SelectedValue = articulo.marca.id;
                    cboCategoria.SelectedValue = articulo.categoria.id;
                    listaImagenes = imagenNegocio.listar(articulo);
                    dgvImagenes.DataSource = listaImagenes;
                    //imagenSelecccionada = (Imagen)dgvImagenes.CurrentRow.DataBoundItem;
                    //cargarImagen(imagenSelecccionada.url); //recibe string entonces le mando la URL de la imagen seleccionada
                    if (listaImagenes.Any()) pbxArticulo.Load(listaImagenes[0].url);
                    dgvImagenes.Columns["url"].HeaderText = "Imagenes";
                    dgvImagenes.Columns["Id"].Visible = false;
                    dgvImagenes.Columns["IdArticulo"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //Articulo newArt = new Articulo(); Ya lo agregue como PROPIEDAD en LINEA 18
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (articulo == null) //Esto seria para que valide cuando Modifica, ya que esta en null solo cuando se va a agregar, sino estaria cargado con el articulo seleccionado LINEA 28
                articulo = new Articulo();



                ///AGREGAR VALIDACIONES!!!!!!!!!!!!!!!!
                articulo.codigo = txtbCodigo.Text;
                articulo.nombre = txtbNombre.Text;
                articulo.descripcion = txtbDescripcion.Text;
                articulo.marca = (Marca)cboMarca.SelectedItem;
                articulo.categoria = (CategoriaArticulo)cboCategoria.SelectedItem;
                //articulo.precio = SqlMoney.Parse(txtbPrecio.Text);
                articulo.precio = decimal.Parse(txtbPrecio.Text);
                decimal precio;
                if (decimal.TryParse(txtbPrecio.Text.Replace('.', ','), out precio))
                {
                    //Asigna el precio convertido al artículo
                    articulo.precio = precio;
                }
                else
                {
                    MessageBox.Show("Ingrese un precio válido.");
                    return; // Salir del método si el precio no es válido
                }

                //articulo.imagenUrl = txtbImagenUrl.Text; //YA TENGO LA LISTA DE IMAGENES

                if (articulo.id != 0)
                {
                    negocio.modificarArticulo(articulo, listaImagenes);
                    MessageBox.Show("Articulo modificado exitosamente");
                    Close();
                }
                else
                {
                negocio.agregarArticulo(articulo, listaImagenes);
                MessageBox.Show("Artículo agregado exitosamente.");
                Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cargarImagen(string imagen)
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

        private void txtbImagenUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtbImagenUrl.Text);
        }

        private void recargarDGVImagenes()
        {
            try
            {
                dgvImagenes.SelectionChanged -= dgvImagenes_SelectionChanged; //suspendo el selectionchanged sino me tira erro Index 1 no existe
                // Limpiar filas existentes en el DataGridView
                dgvImagenes.DataSource = null;
                dgvImagenes.DataSource = listaImagenes;
                dgvImagenes.Refresh();
                dgvImagenes.Columns["url"].HeaderText = "Imagenes";
                dgvImagenes.Columns["Id"].Visible = false;
                dgvImagenes.Columns["IdArticulo"].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                dgvImagenes.SelectionChanged += dgvImagenes_SelectionChanged; //reestablezco el selectionchanged
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
                    Imagen auxAgregada = new Imagen();
            try
            {
                if(articulo == null)
                {
                    if (!txtbImagenUrl.Text.Any())
                    {
                        MessageBox.Show("No puede agregar una URL vacía");
                    }

                    else
                    {
                        
                        auxAgregada.idArticulo = 1;
                        auxAgregada.url = txtbImagenUrl.Text;
                        listaImagenes.Add(auxAgregada);
                        recargarDGVImagenes();
                        //MessageBox.Show("Imagen agregada en <memoria>, no DB");
                        txtbImagenUrl.Clear();
                    }             
                }

                //if(articulo.id != 0) //aca va un else creo 
                else
                {
                    if (!txtbImagenUrl.Text.Any())
                    {
                        MessageBox.Show("No puede agregar una URL vacía");
                    }
                    else
                    {
                        int idArtActual = articulo.id;
                        //Imagen auxAgregada = new Imagen();
                        //NO INICIALIZO listaImagenes porque ya la cargue en la linea 67 cuando entro por <articulo != null>
                        auxAgregada.idArticulo = idArtActual;
                        auxAgregada.url = txtbImagenUrl.Text;
                        listaImagenes.Add(auxAgregada);
                        recargarDGVImagenes();
                        txtbImagenUrl.Clear();
                        //MessageBox.Show("Imagen agregada en <memoria>, no DB");

                    }
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvImagenes_SelectionChanged(object sender, EventArgs e)
        {
            Imagen seleccionado = (Imagen)dgvImagenes.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.url);
        }

        private void btnEliminarImagen_Click(object sender, EventArgs e)
        {
            Imagen auxEliminada = new Imagen();
            try
            {



                /*if(auxEliminada == null)
                {
                    MessageBox.Show("No se puede eliminar si no ha seleccionado algo...");
                    return;
                }*/

                
                if (!(listaImagenes.Any()) || dgvImagenes.RowCount == 0 || dgvImagenes.CurrentRow==null)
                {
                    MessageBox.Show("No se puede eliminar si no ha seleccionado algo...");
                }
                else
                {
                auxEliminada = (Imagen)dgvImagenes.CurrentRow.DataBoundItem;
                listaImagenes.Remove(auxEliminada);
                recargarDGVImagenes();

                    if (dgvImagenes.CurrentRow!=null) //para que no se queje cuando no le quedan elementos
                    {
                        auxEliminada = (Imagen)dgvImagenes.Rows[0].DataBoundItem;
                pbxArticulo.Load(auxEliminada.url);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}