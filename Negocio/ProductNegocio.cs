using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class ProductNegocio
    {

        public IList<Producto> listar()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            IList<Producto> lista = new List<Producto>();
            Producto aux;

            try
            {
                conexion.ConnectionString = @"initial catalog=Rubinstein_DB;data source=DESKTOP-3LK2VR8\SQLEXPRESS;integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select IdProducto,Descripcion from Producto";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    aux = new Producto();
                    aux.IdProducto = (int) lector["IdProducto"];
                    aux.Descripcion = lector.GetString(1);
                    //aux.Tamanio = lector.GetString(2);
                    //Tamanio,PrecioUnitario,Stock,FechaVenc
                    lista.Add(aux);
                }
                return lista;
            }
            catch(Exception ex)
            {
                throw ex;
                
            }
            finally
            {
                lector = null;
                conexion.Close();
            }

        }

    }
}
