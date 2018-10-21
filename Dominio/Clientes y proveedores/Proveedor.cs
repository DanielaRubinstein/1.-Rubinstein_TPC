using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Proveedor : Contacto
    {
        public int CUIT { get; set; }
        public string RazonSocial { get; set; }

        public override string ToString()
        {
            return RazonSocial + "(" + CUIT.ToString() + ")";
        }

    }
}
