using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmVentas VentanaVentas = new frmVentas();
            VentanaVentas.ShowDialog();
            this.Close();
        }

        private void btnIngredientes_Click(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductos VentanaProducto = new frmProductos();
            VentanaProducto.ShowDialog();
            this.Close();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            frmCompras VentanaCompras = new frmCompras();
            VentanaCompras.ShowDialog();
            this.Close();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            frmProveedor VentanaProveedor = new frmProveedor();
            VentanaProveedor.ShowDialog();
            this.Close();

        }
    }
}
