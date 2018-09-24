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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresarUser_Click(object sender, EventArgs e)
        {
            frmPrincipal PantallaPrincipal = new frmPrincipal();
            PantallaPrincipal.ShowDialog();
            this.Close();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
