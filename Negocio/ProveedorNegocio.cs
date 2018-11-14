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
                //conexion.SetearConsulta("select IdProveedor,CUIT from Proveedor");
                conexion.SetearConsulta("select IdProveedor, RazonSocial, CUIT, Mail, Telefono, Celular, direccion from Proveedor where Estado =1 ");
                conexion.abrirConexion();
                conexion.ejecutarConsulta();

                while (conexion.Lector.Read())
                {
                    proveedor = new Proveedor();
                    //proveedor.direccion = new Direccion();
                    //proveedor.IdTelefono = new List<Telefono>(); //es una lista
                    proveedor.IdProveedor = (int)conexion.Lector["IdProveedor"];
                    //proveedor.CUIT = conexion.Lector["CUIT"];
                    //proveedor.direccion.Calle = conexion.Lector.GetString(1);
                    //proveedor.direccion.NroCalle = conexion.Lector.GetInt32(2);
                    proveedor.RazonSocial = conexion.Lector.GetString(1);
                    proveedor.CUIT = conexion.Lector.GetString(2);
                    proveedor.Mail = conexion.Lector.GetString(3);
                    proveedor.Telefono = conexion.Lector.GetString(4);
                    proveedor.Celular = conexion.Lector.GetString(5);
                    proveedor.direccion = conexion.Lector.GetString(6);
                    //proveedor.Estado = conexion.Lector.GetInt32(7);
                    //proveedor.direccion.Calle = (string)conexion.Lector["Calle"];
                    lista.Add(proveedor);
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

        public void modificar(Proveedor proveedor)
        {
            AccesoDatos conexion;
            try
            {
                conexion = new AccesoDatos();
                conexion.SetearConsulta("update PROVEEDOR set RazonSocial=@RazonSocial, CUIT=@CUIT, Mail=@Mail, Telefono=@Telefono, Celular=@Celular,direccion=@direccion where IdProveedor=@IdProveedor");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@RazonSocial", proveedor.RazonSocial);
                conexion.Comando.Parameters.AddWithValue("@CUIT", proveedor.CUIT);
                conexion.Comando.Parameters.AddWithValue("@Mail", proveedor.Mail);
                conexion.Comando.Parameters.AddWithValue("@Telefono", proveedor.Telefono);
                conexion.Comando.Parameters.AddWithValue("@Celular", proveedor.Celular);
                conexion.Comando.Parameters.AddWithValue("@direccion", proveedor.direccion);
                conexion.Comando.Parameters.AddWithValue("@IdProveedor", proveedor.IdProveedor);
                conexion.abrirConexion();
                conexion.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void agregar(Proveedor proveedorNuevo)
        {
            AccesoDatos conexion;
            //string consulta = "";
            try
            {
                conexion = new AccesoDatos();
                //consulta = "insert into PROVEEDOR (RazonSocial=@RazonSocial, CUIT=@CUIT, Mail=@Mail, Telefono=@Telefono, Celular=@Celular,direccion=@direccion)";
                // consulta = consulta + "values("+ proveedorNuevo.RazonSocial+","+proveedorNuevo.CUIT+","+proveedorNuevo.Mail+","+proveedorNuevo.Telefono+","+proveedorNuevo.Celular+","+proveedorNuevo.direccion+")";
                //conexion.SetearConsulta(consulta);

                //conexion.SetearConsulta("insert into PROVEEDOR (RazonSocial=@RazonSocial, CUIT=@CUIT, Mail=@Mail, Telefono=@Telefono, Celular=@Celular,direccion=@direccion)");
                conexion.SetearConsulta("insert into PROVEEDOR (RazonSocial,CUIT,Mail,Telefono,Celular,direccion,Estado) values (@RazonSocial, @CUIT, @Mail, @Telefono, @Celular, @direccion,1)");

                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@RazonSocial", proveedorNuevo.RazonSocial);
                conexion.Comando.Parameters.AddWithValue("@CUIT", proveedorNuevo.CUIT);
                conexion.Comando.Parameters.AddWithValue("@Mail", proveedorNuevo.Mail);
                conexion.Comando.Parameters.AddWithValue("@Telefono", proveedorNuevo.Telefono);
                conexion.Comando.Parameters.AddWithValue("@Celular", proveedorNuevo.Celular);
                conexion.Comando.Parameters.AddWithValue("@Direccion", proveedorNuevo.direccion);
                conexion.Comando.Parameters.AddWithValue("@Estado", proveedorNuevo.Estado);

                conexion.abrirConexion();
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Eliminar(int Id)
        {
            AccesoDatos conexion;
            try
            {
                conexion = new AccesoDatos();
                conexion.SetearConsulta("update PROVEEDOR set Estado=0 where IdProveedor=@IdProveedor");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@IdProveedor", Id);
                conexion.abrirConexion();
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
