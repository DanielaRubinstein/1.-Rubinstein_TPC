using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Ingrediente
    {
        public int IdIngrediente { get; set; }
        public string Descripcion { get; set; }//descripcion de ingrediente
        public float Tamanio { get; set; } //puede ser ml,m3,gr,kg(hacer otro objeto de tamanio de ingrediente, unidad)
        public int IdProveedor { get; set; }
        public string RazonSocial { get; set; }
       // public float Cantidad { get; set; } //cantidad de ese producto
        public Ingrediente() { }
        public Ingrediente(int idIngrediente, string descrip, int tam)
        {
            IdIngrediente = idIngrediente;
            Descripcion = descrip;
            Tamanio = tam;
        }


    }
}
