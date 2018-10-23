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
            Proveedor aux;
            try
            {
                conexion = new AccesoDatos();
                conexion.SetearConsulta("select IdContacto, CUIT, RazonSocial, direccion, localidad, Mail, Telefono");
                conexion.abrirConexion();
                conexion.ejecutarConsulta();

                while (conexion.Lector.Read())
                {
                    aux = new Proveedor();
                    aux.IdContacto = (int)conexion.Lector["IdContacto"];
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
