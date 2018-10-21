using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class DetalleFactura
    {
        public int IdDetalle { get; set; }
        public int IdFactura { get; }
        public Producto producto { get; set; }
        public int Cantidad { get; set; }
        public float PrecioTotal { get; set; }
        public int Descuento { get; set; } //puede ser porcentaje o entero 

        public DetalleFactura() { }
        //Metodo que conecta el id factura, con el detalleorden y el producto
        public DetalleFactura(int idDetalle, int idFactura, int idProducto, string descripcionProd, float precioUnitario, float precioTotal)
        {
            IdDetalle = idDetalle;
            IdFactura = idFactura;
            producto.IdBien = idProducto;
            producto.Descripcion = descripcionProd;
            producto.Precio = precioUnitario;
            PrecioTotal = precioUnitario * Cantidad;
        }

        //clase base insumo (heredar producto e ingrediente)

    }
}
