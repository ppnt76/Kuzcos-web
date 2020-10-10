using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Catologo;
using Dominio;

namespace WindowsFormsApp1
{
    public partial class FormEliminar : Form
    {
        public FormEliminar()
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FormEliminar_Load(object sender, EventArgs e)
        {
            CatologoArticulo catalogo = new CatologoArticulo();
            dgvLista.DataSource = catalogo.Listar();
            dgvLista.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvLista.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvLista.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvLista.Columns[0].Visible = false;
            dgvLista.Columns[1].Visible = false;
            dgvLista.Columns[8].Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CatologoArticulo catalogo = new CatologoArticulo();

            try
            {
                string codigo = ((Articulos)dgvLista.CurrentRow.DataBoundItem).Codigo;
                if (MessageBox.Show("Quiere eliminar el articulo?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    catalogo.Eliminar(codigo);
                    dgvLista.DataSource = catalogo.Listar();
                    dgvLista.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvLista.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                    dgvLista.BackgroundColor = System.Drawing.SystemColors.Control;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
