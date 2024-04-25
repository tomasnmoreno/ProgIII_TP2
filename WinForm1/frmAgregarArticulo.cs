using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
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

        public frmAgregarArticulo()
        {
            InitializeComponent();
        }

        public frmAgregarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }

        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();


            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "id"; //para que cargue los listas despl de Marca. Separo en Value(que campo mira del obj marca)
                cboMarca.DisplayMember = "descripcion"; // Separo Display = que campo muestra del objeto marca
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "id";
                cboCategoria.DisplayMember = "descripcion";

   
                if(articulo != null)
                {
                txtbCodigo.Text = articulo.codigo;
                txtbNombre.Text = articulo.nombre;
                txtbDescripcion.Text = articulo.descripcion;
                txtbPrecio.Text = articulo.precio.ToString();
                txtbImagenUrl.Text = articulo.imagenUrl;
                cargarImagen(articulo.imagenUrl);
                cboMarca.SelectedValue = articulo.marca.id;
                cboCategoria.SelectedValue = articulo.categoria.id;
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

                articulo.codigo = txtbCodigo.Text;
                articulo.nombre = txtbNombre.Text;
                articulo.descripcion = txtbDescripcion.Text;
                articulo.marca = (Marca)cboMarca.SelectedItem;
                articulo.categoria = (CategoriaArticulo)cboCategoria.SelectedItem;
                articulo.precio = SqlMoney.Parse(txtbPrecio.Text);
                articulo.imagenUrl = txtbImagenUrl.Text;

                if(articulo.id != 0)
                {
                    negocio.modificarArticulo(articulo);
                    MessageBox.Show("Articulo modificado exitosamente");
                    Close();
                }
                else
                {
                negocio.agregarArticulo(articulo);
                MessageBox.Show("Artículo agregado exitosamente.");
                Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            
            /*
            //copiar contenido txtbCodigo
            art.codigo = txtbCodigo.Text;
            //copiar contenido txtbNombre
            art.nombre = txtbNombre.Text;
            //copiar contenido txtbDescripcion
            art.descripcion = txtbDescripcion.Text;
            //copiar contenido txtbMarca
            //art.marca = cbbMarca.Text;
            //copiar contenido txtbPrecio
            art.precio = float.Parse(txtbPrecio.Text);
            //copiar contenido cbbCategoria
            //art.categoria = ;
            //guardar imagen de articulo de pbImagenArticulo
            */
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
    }
}
