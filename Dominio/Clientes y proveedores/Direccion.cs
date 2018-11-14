using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Direccion
    {
        public string Calle { get; set; }
        public int NroCalle { get; set; }
        public string Dpto { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }

        public override string ToString()
        {
            return Calle + " " + NroCalle.ToString() + ", " + Dpto.ToString() + ", " + Localidad + ", " + Provincia;
        }

    }


}
