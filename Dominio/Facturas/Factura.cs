using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Factura
    {
        public int IdVenta { get; set; }
        public int IdFactura { get; set; }
        public int IdDetalle { get; set; }
        public int IdContacto { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Fecha { get; set; }

        // agregar dato tipo:compra o venta
        public List<DetalleFactura> DetalleFactura { get; set; }


    }
}
