using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Telefono
    {
        public int IdTelefono { get; set; }
        public int IdPersona { get; }
        public string Tel { get; set; }
        public string TipoTel { get; set; } //oficina, whatsapp,celular,casa
        public Telefono() { }
        public Telefono(int idTelefono, int idPersona, string telefono)
        {
            IdTelefono = idTelefono;
            IdPersona = idPersona;
            Tel = telefono;
        }

    }
}
