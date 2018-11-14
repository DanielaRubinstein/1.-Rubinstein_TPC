using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ClienteNegocio
    {
        public IList<Cliente> listar()
        {
           AccesoDatos conexion = null;
            List<Cliente> lista = new List<Cliente>();
            Cliente cliente;
            try
            {
                conexion = new AccesoDatos();
                conexion.SetearConsulta("select IdCliente, Dni, Nombre, Apellido, Mail, Telefono, Celular, Direccion from Cliente where Estado=1");
                conexion.abrirConexion();
                conexion.ejecutarConsulta();

                while(conexion.Lector.Read())
                {
                    cliente = new Cliente();
                    cliente.IdCliente = (int)conexion.Lector["IdCliente"];
                    cliente.Dni = conexion.Lector.GetString(1);
                    cliente.Nombre = conexion.Lector.GetString(2);
                    cliente.Apellido = conexion.Lector.GetString(3);
                    cliente.Mail = conexion.Lector.GetString(4);
                    cliente.Telefono = conexion.Lector.GetString(5);
                    cliente.Celular = conexion.Lector.GetString(6);
                    cliente.direccion = conexion.Lector.GetString(7);
                    lista.Add(cliente);
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

        public void modificar(Cliente cliente)
        {
            AccesoDatos conexion;
            try
            {
                conexion = new AccesoDatos();
                conexion.SetearConsulta("Update CLIENTE set Dni=@Dni,Nombre=@Nombre,Apellido=@Apellido,Mail=@Mail, Telefono=@Telefono,Celular=@Celular,Direccion=@Direccion where IdCliente=@IdCliente");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@Dni",cliente.Dni);
                conexion.Comando.Parameters.AddWithValue("@Nombre",cliente.Nombre);
                conexion.Comando.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                conexion.Comando.Parameters.AddWithValue("@Mail", cliente.Mail);
                conexion.Comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                conexion.Comando.Parameters.AddWithValue("@Celular", cliente.Celular);
                conexion.Comando.Parameters.AddWithValue("@Direccion", cliente.direccion);
                conexion.Comando.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
                conexion.abrirConexion();
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void agregar(Cliente clienteNuevo)
        {
            AccesoDatos conexion;
            try
            {
                conexion = new AccesoDatos();
                conexion.SetearConsulta("Insert into CLIENTE(Dni,Nombre,Apellido,Mail,Telefono,Celular,Direccion,Estado) values (@Dni,@Nombre,@Apellido,@Mail,@Telefono,@Celular,@Direccion,1)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@Dni", clienteNuevo.Dni);
                conexion.Comando.Parameters.AddWithValue("@Nombre", clienteNuevo.Nombre);
                conexion.Comando.Parameters.AddWithValue("@Apellido", clienteNuevo.Apellido);
                conexion.Comando.Parameters.AddWithValue("@Mail", clienteNuevo.Mail);
                conexion.Comando.Parameters.AddWithValue("@Telefono", clienteNuevo.Telefono);
                conexion.Comando.Parameters.AddWithValue("@Celular",clienteNuevo.Celular);
                conexion.Comando.Parameters.AddWithValue("@Direccion",clienteNuevo.direccion);
                conexion.Comando.Parameters.AddWithValue("@Estado",clienteNuevo.Estado);

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
                conexion.SetearConsulta("update CLIENTE set Estado=0 where IdCliente=@IdCliente");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@IdCliente", Id);
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
