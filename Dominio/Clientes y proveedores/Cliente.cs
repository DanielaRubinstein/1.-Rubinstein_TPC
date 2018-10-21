using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente : Contacto
    {
   
        public int Dni { get; set; } //no es obligatorio
        public string Nombre { get; set; }
        public string Apellido { get; set; }


    //quizas podria agregar fecha de cumpleanios para las tortas y que mande mail cuando se este acercando la fecha


    }
}
