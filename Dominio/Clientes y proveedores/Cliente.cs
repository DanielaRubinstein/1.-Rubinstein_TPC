using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public Direccion direccion { get; set; }
        public List<Telefono> Telefono { get; set; }
        public string Mail { get; set; }
        public int Dni { get; set; } //no es obligatorio
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public override string ToString()
        {
            return IdCliente + " " + direccion + ", " + Telefono + ", " + Mail;
        }


        //quizas podria agregar fecha de cumpleanios para las tortas y que mande mail cuando se este acercando la fecha


    }
}
