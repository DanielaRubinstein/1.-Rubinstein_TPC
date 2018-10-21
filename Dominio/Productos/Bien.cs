using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Bien
    {
        public int IdBien { get; set; }
        public string Descripcion { get; set; }
        public Medida medida { get; set; }
        public Categoria categoria { get; set; } // tipo de torta , tipo de cerveza
        public float Tamanio { get; set; } // podria poner tamanio en gr kg l ml o m3
        public float Precio { get; set; }
        public float Cantidad { get; set; }
        public DateTime FechaVencimiento { get; set; }
        //en caso de la cerveza deberia poner tiempo de fermentacion

    }
}
