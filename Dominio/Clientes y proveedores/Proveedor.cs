using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public Direccion direccion { get; set; }
        public List<Telefono> telefono { get; set; }
        public string mail { get; set; }
        public int CUIT { get; set; }
        public string RazonSocial { get; set; }


        public override string ToString()
        {
            return IdProveedor +" " + direccion + ", " + telefono + ", " + mail + ", " + RazonSocial + "(" + CUIT.ToString() + ")";
        }

    }
}
