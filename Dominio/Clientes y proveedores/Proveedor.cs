using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Proveedor
    {
        public int IdPersona { get; set; }
        public int Cuit { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public Telefono Telefono { get; set; }
        public string Mail { get; set; }

    }
}
