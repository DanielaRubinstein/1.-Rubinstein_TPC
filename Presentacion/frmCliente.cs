using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class frmCliente : Form
    {
        private Cliente cliente = null;
        public frmCliente()
        {
            InitializeComponent();
        }

        public frmCliente(Cliente modificado)
        {
            InitializeComponent();
            cliente = modificado; 
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ClienteNegocio clientNeg = new ClienteNegocio();
            try
            {
                if(cliente == null)
                {
                    cliente = new Cliente();
                }
                //if (txtboxDireccion.Text.Trim() == "" || txtboxDireccion.Text.Trim() == "")
                //{
                //    MessageBox.Show("La direccion es obligatoria");
                //    return;
                //}

                cliente.Dni = txtBoxDni.Text;
                cliente.Nombre = txtBoxNombre.Text;
                cliente.Apellido = txtBoxApellido.Text;
                cliente.Mail = txtBoxMail.Text;
                cliente.Telefono = txtBoxTelefono.Text;
                cliente.Celular = txtBoxCelular.Text;
                cliente.direccion = txtBoxDireccion.Text;

                if(cliente.IdCliente!=0)
                {
                    clientNeg.modificar(cliente);
                    MessageBox.Show("Modificado correctamente");
                }
                else
                {
                    clientNeg.agregar(cliente);
                    MessageBox.Show("Agregado correctamente");
                }
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void frmCliente_Load(object sender,EventArgs e)
        {
            try
            {
                if(cliente!=null)
                {
                    txtBoxIdCliente.Text = cliente.IdCliente.ToString();
                    txtBoxDni.Text = cliente.Dni;
                    txtBoxNombre.Text = cliente.Nombre;
                    txtBoxApellido.Text = cliente.Apellido;
                    txtBoxMail.Text = cliente.Mail;
                    txtBoxTelefono.Text = cliente.Telefono;
                    txtBoxCelular.Text = cliente.Celular;
                    txtBoxDireccion.Text = cliente.direccion;
                    Text = "Modificar";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
