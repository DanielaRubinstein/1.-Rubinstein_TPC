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
    public partial class frmListaCliente : Form
    {
        private List<Cliente> listaCliente;
        public frmListaCliente()
        {
            InitializeComponent();
        }

        private void frmListaCliente_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            ClienteNegocio clientNeg = new ClienteNegocio();
            try
            {
                dgvClientes.DataSource = clientNeg.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmCliente formCliente = new frmCliente();
            formCliente.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClienteNegocio clientNeg = new ClienteNegocio();
            try
            {
                clientNeg.Eliminar((int)dgvClientes.CurrentRow.Cells[0].Value);
                MessageBox.Show("Eliminacion exitosa");
                cargar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error!");
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Cliente modificado;
            try
            {
                modificado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                frmCliente modi = new frmCliente(modificado);
                modi.ShowDialog();
                cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
