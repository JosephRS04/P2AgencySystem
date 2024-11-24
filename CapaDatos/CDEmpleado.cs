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
    public class CDEmpleado 
    {
        private int dIdEmpleado, dIdRol;
        private string dNombre, dApellido, dTelefono, dEstado;
        DateTime dFechaNacimiento;

        public CDEmpleado() { }

        public CDEmpleado( int pIdEmpleado, string pNombre, string pApellido, DateTime pFechaNacimiento, int pIdRol, string pTelefono, string pEstado)

        {
            dIdEmpleado = pIdEmpleado;
            dNombre = pNombre;
            dApellido = pApellido;
            dTelefono = pTelefono;
            dFechaNacimiento = pFechaNacimiento;
            dIdRol = pIdRol;
            dEstado = pEstado;
        }


        #region Métodos Get y Set 

        public int IdEmpleado
        {
            get { return dIdEmpleado; }
            set { dIdEmpleado = value; }
        }

        public string Nombre
        {
            get { return dNombre; }
            set { dNombre = value; }
        }

        public string Apellido
        {
            get { return dApellido; }
            set { dApellido = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return dFechaNacimiento; }
            set { dFechaNacimiento = value; }
        }

        public int IdRol
        {
            get { return dIdRol; }
            set { dIdRol = value; }
        }

        public string Telefono
        {
            get { return dTelefono; }
            set { dTelefono = value; }
        }

        public string Estado
        {
            get { return dEstado; }
            set { dEstado = value; }
        }

        #endregion
        // Método para insertar un nuevo registro en Empleado 

        public string Insertar(CDEmpleado objEmpleado)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {

                sqlCon.ConnectionString = P2Conexion.miconexion;
                SqlCommand micomando = new SqlCommand("EmpleadoInsertar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pNombre", objEmpleado.Nombre);
                micomando.Parameters.AddWithValue("@pApellido", objEmpleado.Apellido);
                micomando.Parameters.AddWithValue("@pTelefono", objEmpleado.Telefono);
                micomando.Parameters.AddWithValue("@pFechaNacimineto", objEmpleado.FechaNacimiento);
                micomando.Parameters.AddWithValue("@pEstado", objEmpleado.Estado);
                micomando.Parameters.AddWithValue("@pIdRol", objEmpleado.IdRol);

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



        // Método para actualizar un registro existente en Empleado 
        public string Actualizar(CDEmpleado objEmpleado)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = P2Conexion.miconexion;
                SqlCommand micomando = new SqlCommand("EmpleadoActualizar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pIdEmpleado", objEmpleado.IdEmpleado);
                micomando.Parameters.AddWithValue("@pNombre", objEmpleado.Nombre);
                micomando.Parameters.AddWithValue("@pApellido", objEmpleado.Apellido);
                micomando.Parameters.AddWithValue("@pTelefono", objEmpleado.Telefono);
                micomando.Parameters.AddWithValue("@pFechaNacimiento", objEmpleado.FechaNacimiento);
                micomando.Parameters.AddWithValue("@pEstado", objEmpleado.Estado);
                micomando.Parameters.AddWithValue("@pIdRol", objEmpleado.IdRol);

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



        // Método para consultar registros en Empleado 
        public DataTable EmpleadoConsultar(string parametro)
        {
            DataTable dt = new DataTable();
            SqlDataReader leerDatos;
            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = new P2Conexion().dbconexion;
                sqlCmd.Connection.Open();
                sqlCmd.CommandText = "EmpleadoConsultar";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pvalor", parametro);
                leerDatos = sqlCmd.ExecuteReader();
                dt.Load(leerDatos);
                sqlCmd.Connection.Close();
            }
            catch (Exception ex)
            {
                dt = null; //Si ocurre algun error se anula el DataTable 
            }
            return dt;

        }
    }
}