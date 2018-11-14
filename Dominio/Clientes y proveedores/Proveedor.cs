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
        public string RazonSocial { get; set; }
        public string CUIT { get; set; }
        public string Mail { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string direccion { get; set; }
        public int Estado { get; set; }

        public override string ToString()
        {
            return IdProveedor + " ," + RazonSocial + ", " + CUIT + ", " + Mail +", "+ Telefono +", " + ", " + Celular+ ","+direccion+","+1;
        }

    }
}
