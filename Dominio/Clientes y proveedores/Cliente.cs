using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Cliente
    {
        public int IdPersona { get; set; }
        public int Dni { get; set; } //no es obligatorio
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public List<Telefono> Telefono { get; set; }
        public string Mail { get; set; }

        
        

    //quizas podria agregar fecha de cumpleanios para las tortas y que mande mail cuando se este acercando la fecha



    }
}
