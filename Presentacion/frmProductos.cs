using System;
using System.Windows.Forms;
using Negocio;
using Dominio;


namespace Presentacion
{
    public partial class frmProductos : Form
    {
        //private Producto producto;
        public frmProductos()
        {
            InitializeComponent();
        }

        //public frmProductos(Producto prod)
        //{
        //    InitializeComponent();
        //    producto = prod;
        //}

        private void frmProductos_Load(object sender, EventArgs e)
        {
            

        }

        private void btnVerProducto_Click(object sender, EventArgs e)
        {
            ProductNegocio productNegocio = new ProductNegocio();

            try
            {
                //dgvProductos.Visible = true; //por defecto esta oculto, se muestra apretando btn ver
                dgvProductos.DataSource = productNegocio.listar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

    }
}
