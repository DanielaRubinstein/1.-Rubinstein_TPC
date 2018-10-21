using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace Presentacion
{
    public partial class frmListaProveedor : Form
    {
 
        public frmListaProveedor()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmProveedor ventanaProveedor = new frmProveedor();
            ventanaProveedor.ShowDialog();
            this.Close();
        }

    }
}
