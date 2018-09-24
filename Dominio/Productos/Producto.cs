using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto // puede ser cerveza o torta
    {
        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public int Categoria { get; set; } // tipo de torta , tipo de cerveza
        public float Tamanio { get; set; } // podria poner tamanio en gr kg l ml o m3
        public float Precio { get; set; }
        public float Stock { get; set; }
        public DateTime FechaVencimiento { get; set; } 
        //en caso de la cerveza deberia poner tiempo de fermentacion
    }
}
