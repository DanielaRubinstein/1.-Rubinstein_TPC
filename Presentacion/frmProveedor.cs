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
    public partial class frmProveedor : Form   
    {
        private Proveedor proveedor = null;
        public frmProveedor()
        {
            InitializeComponent();
        }

        public frmProveedor(Proveedor modificado)
        {
            InitializeComponent();
            proveedor = modificado;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ProveedorNegocio proveedorNegocio = new ProveedorNegocio();
            try
            {
                if (proveedor == null)
                {
                    proveedor = new Proveedor();
                }

                //proveedor.RazonSocial = txtboxRazonSocial.Text;
                if (txtboxRazonSocial.Text.Trim() == "" || txtboxRazonSocial.Text.Trim() == "")
                {
                    MessageBox.Show("La razon social es obligatoria");
                    return;
                }
                
                proveedor.RazonSocial = txtboxRazonSocial.Text;
                proveedor.CUIT = txtboxCuit.Text;
                proveedor.Mail = txtboxMail.Text;
                proveedor.Telefono = txtboxTelefono.Text;
                proveedor.Celular = txtboxCelular.Text;
                proveedor.direccion = txtboxDireccion.Text;
                //propiedad.SuperficieDescubierta = int.Parse(txtSuperficieDescubierta.Text);

                if (proveedor.IdProveedor != 0)
                {
                    proveedorNegocio.modificar(proveedor);
                    MessageBox.Show("Modificado Correctamente.");
                }
                else
                {
                    //proveedor.IdProveedor = proveedorNegocio.agregar(proveedor.IdProveedor);
                    proveedorNegocio.agregar(proveedor);
                    MessageBox.Show("Agregado Correctamente.");
                }

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            try
            {
                if (proveedor != null)
                {
                    txtboxIdProveedor.Text = proveedor.IdProveedor.ToString();
                    txtboxRazonSocial.Text = proveedor.RazonSocial;
                    txtboxCuit.Text = proveedor.CUIT;
                    txtboxMail.Text = proveedor.Mail;
                    txtboxTelefono.Text = proveedor.Telefono;
                    txtboxCelular.Text = proveedor.Celular;
                    txtboxDireccion.Text = proveedor.direccion;
                    Text = "Modificar";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtboxIdProveedor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
