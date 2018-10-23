using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ProveedorNegocio
    {
       public IList<Proveedor> listar()
        {

            AccesoDatos conexion = null;
            List<Proveedor> lista = new List<Proveedor>();
            Proveedor proveedor;
            try
            {
                conexion = new AccesoDatos();
                conexion.SetearConsulta("select IdProveedor, CUIT, RazonSocial, direccion, localidad, Mail, Telefono from Proveedor");
                conexion.abrirConexion();
                conexion.ejecutarConsulta();

                while (conexion.Lector.Read())
                {
                    proveedor = new Proveedor();
                    proveedor.direccion = new Direccion();
                    //proveedor.telefono.Tel = new Telefono(); es una lista
                    proveedor.IdProveedor = (int)conexion.Lector["IdProveedor"];
                    proveedor.CUIT = (int)conexion.Lector["CUIT"];
                    proveedor.direccion.Calle = (string)conexion.Lector["Calle"];

                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion != null)
                    conexion.cerrarConexion();
            }

        }
    }
}
