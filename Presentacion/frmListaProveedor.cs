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

        private List<Proveedor> listaProveedores;
 
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
                dgvProveedores.Columns[7].Visible = false;
                // dgvProveedores.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //dgvProveedores.Columns[2].Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //frmProveedor ventanaProveedor = new frmProveedor();
            //ventanaProveedor.ShowDialog();
            //this.Close();
            Proveedor modificado;
            try
            {
                modificado = (Proveedor)dgvProveedores.CurrentRow.DataBoundItem;
                frmProveedor modi = new frmProveedor(modificado);
                modi.ShowDialog();
                cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmProveedor formProveedor = new frmProveedor();
            formProveedor.ShowDialog();
            cargar();
        }

        private void txtBoxBuscar_KeyPressed(object sender, EventArgs e)
        {
            if (txtBoxBuscar.Text == "")
            {
                dgvProveedores.DataSource = listaProveedores;
            }
            else
            {
                List<Proveedor> lista;
                lista = listaProveedores.FindAll(AUXILIAR => AUXILIAR.RazonSocial.ToLower().Contains(txtBoxBuscar.Text.ToLower()));
                dgvProveedores.DataSource = lista;
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ProveedorNegocio provNeg = new ProveedorNegocio();
            try
            {
                provNeg.Eliminar((int)dgvProveedores.CurrentRow.Cells[0].Value);
                MessageBox.Show("Eliminacion exitosa");
                cargar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error!");
            }

        }


    }
}
