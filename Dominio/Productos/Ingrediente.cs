using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Ingrediente: Bien
    {
        
        public int IdProveedor { get; set; }
        public string RazonSocial { get; set; }
        public Ingrediente() { }
        public Ingrediente(int idIngrediente, string descrip, int tam)
        {
            IdBien = idIngrediente;
            Descripcion = descrip;
            Tamanio = tam;
        }


    }
}
