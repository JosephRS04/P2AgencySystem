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
    public class CDVentaCabecera
    {
        private int dIdventaCabecera, dIdCliente, dIdEmpleado, dCondicion, dCantidad;
        private string dNCF, dTipoFactura, dEstado;
        private DateTime dFecha;

        public CDVentaCabecera()
        {
        }

        public CDVentaCabecera(int pIdventaCabecera, DateTime pFecha, int pIdCliente, int pIdEmpleado, String pNCF, string pTipoFactura, int pCondicion, string pEstado)
        {
            dIdventaCabecera = pIdventaCabecera;
            dFecha = pFecha;
            dIdCliente = pIdCliente;
            dIdEmpleado = pIdEmpleado;
            dNCF = pNCF;
            dTipoFactura = pTipoFactura;
            dCondicion = pCondicion;
            dEstado = pEstado;
        }


        #region metodos get set 
        public int IdventaCabecera
        {
            get { return dIdventaCabecera; }
            set { dIdventaCabecera = value; }
        }

        public DateTime Fecha
        {
            get { return dFecha; }
            set { dFecha = value; }
        }

        public int IdCliente
        {
            get { return dIdCliente; }
            set { dIdCliente = value; }
        }

        public int IdEmpleado
        {
            get { return dIdEmpleado; }
            set { dIdEmpleado = value; }
        }

        public string NCF
        {
            get { return dNCF; }
            set { dNCF = value; }
        }

        public string TipoFactura
        {
            get { return dTipoFactura; }
            set { dTipoFactura = value; }
        }

        public int Condicion
        {
            get { return dCondicion; }
            set { dCondicion = value; }
        }

        public string Estado
        {
            get { return dEstado; }
            set { dEstado = value; }
        }

        #endregion

        public string Insertar(CDVentaCabecera objVentaCabecera)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = P2Conexion.miconexion;
                SqlCommand micomando = new SqlCommand("VentaCabeceraInsertar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pFecha", objVentaCabecera.Fecha);
                micomando.Parameters.AddWithValue("@pIdCliente", objVentaCabecera.IdCliente);
                micomando.Parameters.AddWithValue("@pIdEmpleado", objVentaCabecera.IdEmpleado);
                micomando.Parameters.AddWithValue("@pNCF", objVentaCabecera.NCF);
                micomando.Parameters.AddWithValue("@pTipoFactura", objVentaCabecera.TipoFactura);
                micomando.Parameters.AddWithValue("@pCondicion", objVentaCabecera.Condicion);
                micomando.Parameters.AddWithValue("@pEstado", objVentaCabecera.Estado);

                mensaje = micomando.ExecuteNonQuery() == 1 ? "Insercion de datos completada correctamente" : "No se pudo insertar correctamente los datos"; // instruccion para insertar alguna instruccion sql que solo devuelve texto o nada 
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
        }// fin metodo insertar 


        public string Actualizar(CDVentaCabecera objVentaCabecera)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = P2Conexion.miconexion;
                SqlCommand micomando = new SqlCommand("VentaCabeceraActualizar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pIdVentaCabecera", objVentaCabecera.IdventaCabecera);
                micomando.Parameters.AddWithValue("@pFecha", objVentaCabecera.Fecha);
                micomando.Parameters.AddWithValue("@pIdCliente", objVentaCabecera.IdCliente);
                micomando.Parameters.AddWithValue("@pIdEmpleado", objVentaCabecera.IdEmpleado);
                micomando.Parameters.AddWithValue("@pNCF", objVentaCabecera.NCF);
                micomando.Parameters.AddWithValue("@pTipoFactura", objVentaCabecera.TipoFactura);
                micomando.Parameters.AddWithValue("@pCondicion", objVentaCabecera.Condicion);
                micomando.Parameters.AddWithValue("@pEstado", objVentaCabecera.Estado);

                mensaje = micomando.ExecuteNonQuery() == 1 ? "Actualizacion de datos completada correctamente" :
                    "No se pudo actualizar correctamente los datos!"; // instruccion para insertar alguna instruccion sql que solo devuelve texto o nada 
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
        }// fin metodo actualizar 


        public DataTable VentaCabeceraConsultar(String parametro)
        {
            DataTable dt = new DataTable(); //Se Crea DataTable que tomará los datos de los Suplidores  
            SqlDataReader leerDatos; //Creamos el DataReader  
            try
            {
                SqlCommand sqlCmd = new SqlCommand(); //Establecer el comando  
                sqlCmd.Connection = new P2Conexion().dbconexion; //Conexión que va a usar el comando  
                sqlCmd.Connection.Open(); //Se abre la conexión  
                sqlCmd.CommandText = "VentaCabeceraConsultar"; //Nombre del Proc. Almacenado a usar  
                sqlCmd.CommandType = CommandType.StoredProcedure; //Se trata de un proc. almacenado  
                sqlCmd.Parameters.AddWithValue("@pvalor", parametro); //Se pasa el valor a buscar  
                leerDatos = sqlCmd.ExecuteReader(); //Llenamos el SqlDataReader con los datos resultantes  
                dt.Load(leerDatos); //Se cargan los registros devueltos al DataTable  
                sqlCmd.Connection.Close(); //Se cierra la conexión  
            }
            catch (Exception ex)
            {
                dt = null; //Si ocurre algun error se anula el DataTable  
            }
            return dt; ////Se retorna el DataTable segun lo ocurrido arriba  
        } //Fin del método MostrarConFiltro 

    }// fin clase 

}