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
    public class CDCliente
    {
        private int idCliente;
        private string nombre, apellido, identificacion, direccion, telefono, estado;

        public CDCliente() { }

        public CDCliente(string pNombre, string pApellido, string pIdentificacion, string pDireccion, string pTelefono, string pEstado = "Activo")

        {
            nombre = pNombre;
            apellido = pApellido;
            identificacion = pIdentificacion;
            direccion = pDireccion;
            telefono = pTelefono;
            estado = pEstado;
        }

        #region Métodos Get y Set 

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        #endregion



        // Método para insertar un nuevo registro en Cliente 

        public string Insertar(CDCliente objCliente)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {

                sqlCon.ConnectionString = P2Conexion.miconexion;
                SqlCommand micomando = new SqlCommand("ClienteInsertar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@Nombre", objCliente.Nombre);
                micomando.Parameters.AddWithValue("@Apellido", objCliente.Apellido);
                micomando.Parameters.AddWithValue("@Identificacion", objCliente.Identificacion);
                micomando.Parameters.AddWithValue("@Direccion", objCliente.Direccion);
                micomando.Parameters.AddWithValue("@Telefono", objCliente.Telefono);
                micomando.Parameters.AddWithValue("@Estado", objCliente.Estado);

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



        // Método para actualizar un registro existente en Cliente 
        public string Actualizar(CDCliente objCliente)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {

                sqlCon.ConnectionString = P2Conexion.miconexion;
                SqlCommand micomando = new SqlCommand("ClienteActualizar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@IdCliente", objCliente.IdCliente);
                micomando.Parameters.AddWithValue("@Nombre", objCliente.Nombre);
                micomando.Parameters.AddWithValue("@Apellido", objCliente.Apellido);
                micomando.Parameters.AddWithValue("@Identificacion", objCliente.Identificacion);
                micomando.Parameters.AddWithValue("@Direccion", objCliente.Direccion);
                micomando.Parameters.AddWithValue("@Telefono", objCliente.Telefono);
                micomando.Parameters.AddWithValue("@Estado", objCliente.Estado);

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



        // Método para consultar registros en Cliente 
        public DataTable ClienteConsultar(string parametro)
        {

            DataTable dt = new DataTable(); 
            SqlDataReader leerDatos; 
            try
            {

                SqlCommand sqlCmd = new SqlCommand(); 
                sqlCmd.Connection = new P2Conexion().dbconexion; 
                sqlCmd.Connection.Open(); 
                sqlCmd.CommandText = "ClienteConsultar"; 
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
