using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;

namespace CapaDatos
{
    public class CDUsuario
    {
        private int dIdUsuario, dIdEmpleado, dIdRol;
        private string dUsuario, dClave, dEstado;

        public CDUsuario() { }

        public CDUsuario(int pIdUsuario, int pIdEmpleado, string pUsuario, string pClave, int pIdRol, string pEstado)

        {
            dIdUsuario = pIdUsuario;
            dUsuario = pUsuario;
            dClave = pClave;
            dIdEmpleado = pIdEmpleado;
            dIdRol = pIdRol;
            dEstado = pEstado;
        }


        #region Métodos Get y Set 
        public int IdEmpleado
        {
            get { return dIdEmpleado; }
            set { dIdEmpleado = value; }
        }

        public int IdUsuario
        {
            get { return dIdUsuario; }
            set { dIdUsuario = value; }
        }

        public string Clave
        {
            get { return dClave; }
            set { dClave = value; }
        }

        public string Usuario
        {
            get { return dUsuario; }
            set { dUsuario = value; }
        }

        public int IdRol
        {
            get { return dIdRol; }
            set { dIdRol = value; }
        }


        public string Estado
        {
            get { return dEstado; }
            set { dEstado = value; }
        }

        #endregion
        // Método para insertar un nuevo registro en Usuario 

        public string Insertar(CDUsuario objUsuario)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = P2Conexion.miconexion;
                SqlCommand micomando = new SqlCommand("UsuarioInsertar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pUsuario", objUsuario.Usuario);
                micomando.Parameters.AddWithValue("@pClave", objUsuario.Clave);
                micomando.Parameters.AddWithValue("@pIdEmpleado", objUsuario.IdEmpleado);
                micomando.Parameters.AddWithValue("@pIdRol", objUsuario.IdRol);
                micomando.Parameters.AddWithValue("@pEstado", objUsuario.Estado);

                mensaje = micomando.ExecuteNonQuery() == 1 ? "Inserción de datos completada correctamente" : "No se pudo insertar los datos";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            return mensaje;
        }



        // Método para actualizar un registro existente en Usuario 
        public string Actualizar(CDUsuario objUsuario)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {

                sqlCon.ConnectionString = P2Conexion.miconexion;
                SqlCommand micomando = new SqlCommand("UsuarioActualizar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pIdUsuario", objUsuario.IdUsuario);
                micomando.Parameters.AddWithValue("@pUsuario", objUsuario.Usuario);
                micomando.Parameters.AddWithValue("@pClave", objUsuario.Clave);
                micomando.Parameters.AddWithValue("@pIdEmpleado", objUsuario.IdEmpleado);
                micomando.Parameters.AddWithValue("@pIdRol", objUsuario.IdRol);
                micomando.Parameters.AddWithValue("@pEstado", objUsuario.Estado);
                mensaje = micomando.ExecuteNonQuery() == 1 ? "actualización de datos completada correctamente" : "No se pudo actualizar los datos";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            return mensaje;
        }



        // Método para consultar registros en Usuario 
        public DataTable UsuarioConsultar(string parametro)
        {
            DataTable dt = new DataTable();
            SqlDataReader leerDatos;
            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = new P2Conexion().dbconexion;
                sqlCmd.Connection.Open();
                sqlCmd.CommandText = "UsuarioConsultar";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pvalor", parametro);
                leerDatos = sqlCmd.ExecuteReader();
                dt.Load(leerDatos);
                sqlCmd.Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                dt = null;
            }
            return dt;
        }
    }
}
