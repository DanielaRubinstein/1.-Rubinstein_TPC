using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Telefono
    {
        public int IdTelefono { get; set; }
        public int IdContacto { get; }
        public string Tel { get; set; }
        public string TipoTel { get; set; } //oficina, whatsapp,celular,casa
        public Telefono() { }
        public Telefono(int idTelefono, int idPersona, string telefono)
        {
            IdTelefono = idTelefono;
            IdContacto = idPersona;
            Tel = telefono;
        }

        public override string ToString()
        {
            return  Tel + ", " + TipoTel;
        }

    }
}
