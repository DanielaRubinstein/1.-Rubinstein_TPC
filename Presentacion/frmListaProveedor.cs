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

        //private List<Proveedor> listaProveedores;
 
        public frmListaProveedor()
        {
            InitializeComponent();
        }
        private void frmListaProveedor_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            ProveedorNegocio provNeg = new ProveedorNegocio();
            try
            {
                //listaProveedores = (List<Proveedor>)provNeg.listar();
                dgvProveedores.DataSource = provNeg.listar();
                // dgvProveedores.DataSource = listaProveedores;
                // dgvProveedores.Columns[0].Visible = true;
                // dgvProveedores.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //dgvProveedores.Columns[2].Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmProveedor ventanaProveedor = new frmProveedor();
            ventanaProveedor.ShowDialog();
            this.Close();
        }

    }
}
