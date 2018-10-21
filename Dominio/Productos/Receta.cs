using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Receta
    {
        public int IdReceta { get; set; }
        public int IdProducto { get; }
        public string Descripcion { get;} //toma el nombre de producto
        public List<Ingrediente> Ingrediente { get; set; }

        //para la cerveza, agregar fermentacion, check list,nrofermentadores

    }
}
