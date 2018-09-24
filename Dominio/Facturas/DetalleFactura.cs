using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class DetalleFactura
    {
        public int IdDetalle { get; set; }
        public int IdFactura { get; }
        public int IdProducto { get;}//poner objeto produ
        public string DescripcionProd { get; }//descrip del producto
        public int Cantidad { get; set; }
        public float PrecioUnitario { get; }
        public float PrecioTotal { get; set; }
        public int Descuento { get; set; } //puede ser porcentaje o entero 

        public DetalleFactura() { }
        //Metodo que conecta el id factura, con el detalleorden y el producto
        public DetalleFactura(int idDetalle, int idFactura, int idProducto, string descripcionProd, float precioUnitario, float precioTotal)
        {
            IdDetalle = idDetalle;
            IdFactura = idFactura;
            IdProducto = idProducto;
            DescripcionProd = descripcionProd;
            PrecioUnitario = precioUnitario;
            PrecioTotal = precioUnitario * Cantidad;
        }

        //clase base insumo (heredar producto e ingrediente)

    }
}
