using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Contacto
    {
        public int IdContacto { get; set; }
        public Direccion direccion { get; set; }
        public List<Telefono> Telefono { get; set; }
        public string Mail { get; set; }

        public override string ToString()
        {
            return IdContacto + " " + direccion + ", " + Telefono + ", " + Mail;
        }




    }
}
