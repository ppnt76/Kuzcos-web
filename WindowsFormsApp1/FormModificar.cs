using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Catologo;
using Dominio;

namespace WindowsFormsApp1
{
    public partial class FormModificar : Form
    {
       

        public List<Articulos> Lista { get; private set; }

        public object Y { get; private set; }

        public FormModificar()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;    //centrar pantalla.
            this.ClientSize = new Size(820, 490);

            Bitmap img = new Bitmap(Application.StartupPath + @"\Img\MUNDOVIOLETA.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
            MessageBox.Show("Cancelaste la Modificacion");
        }

        private void tBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Articulos> Busqueda;
            CatologoArticulo BuscarArticulo = new CatologoArticulo();
            Lista = BuscarArticulo.Listar();
            try
            {
                
                if (tBuscar.Text==" ")
                {
                    dGVModificar.DataSource = Lista;
                    Busqueda = Lista;
                    
                }
                else
                {
                    Busqueda = Lista.FindAll(Y => Y.Codigo.ToLower().Contains(tBuscar.Text.ToLower()));
                    dGVModificar.DataSource = Busqueda;
                    dGVModificar.Columns[0].Visible = false;
                    dGVModificar.Columns[1].Visible = false;
                    dGVModificar.Columns[8].Visible = false;
                }
                dGVModificar.DataSource = Busqueda;
                dGVModificar.Columns[0].Visible = false;
                dGVModificar.Columns[1].Visible = false;
                dGVModificar.Columns[8].Visible = false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

       private void bEditar_Click(object sender, EventArgs e)
        {
            if(dGVModificar.SelectedRows.Count>0)
            {
                
                tCodigo.Text = dGVModificar.CurrentRow.Cells["Codigo"].Value.ToString();
                tBNombre.Text = dGVModificar.CurrentRow.Cells["Nombre"].Value.ToString();
                tBDesc.Text = dGVModificar.CurrentRow.Cells["Descripcion"].Value.ToString();
                cBMarca.Text = dGVModificar.CurrentRow.Cells["Marca"].Value.ToString();
                cBCategoria.Text = dGVModificar.CurrentRow.Cells["Categoria"].Value.ToString();
                tBImagen.Text = dGVModificar.CurrentRow.Cells["Imagen"].Value.ToString();
                tBPrecio.Text = dGVModificar.CurrentRow.Cells["Precio"].Value.ToString();
                tbxId.Text = dGVModificar.CurrentRow.Cells["IdArticulo"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una Fila");
            }

        }

        private void FormModificar_Load(object sender, EventArgs e)
        {
            CatologoArticulo cargar = new CatologoArticulo();
            Dominio.Articulos articulo = new Articulos();

            try
            {
                cBMarca.DataSource = cargar.ListarMarca();
                cBMarca.DisplayMember = "Descripcion";
                cBMarca.ValueMember = "Id";
                cBMarca.SelectedIndex = -1;
                cBMarca.SelectedValue = articulo.Marca.idMarca;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Seleccione");
            }
            CatologoArticulo auxcargar = new CatologoArticulo();
            try
            {
                cBCategoria.DataSource = auxcargar.ListarCategoria();
                cBCategoria.DisplayMember = "Descripcion";
                cBCategoria.ValueMember = "Id";
                cBCategoria.SelectedIndex = -1;
                cBCategoria.SelectedValue = articulo.categoria.idCategoria;
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            CatologoArticulo modificar = new CatologoArticulo();
            try
            {
                Dominio.Articulos articulo = new Articulos();
                //articulo.idArticulo = Convert.ToInt32(tbxId);
                articulo.Nombre = tBNombre.Text;
                articulo.Codigo = tCodigo.Text;
                articulo.Descripcion = tBDesc.Text;
                articulo.Imagen = tBImagen.Text;
                articulo.Marca = (Dominio.Marcas)cBMarca.SelectedItem;
                articulo.categoria = (Dominio.Categoria)cBCategoria.SelectedItem;
                articulo.Precio = Convert.ToDecimal(tBPrecio.Text);
                modificar.Editar(articulo);
                Dispose();

            }
            catch(Exception ex)
            {
                throw ex;
            }
           
        }
    }
}
