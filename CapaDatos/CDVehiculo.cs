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
    public class CDVehiculo
    {
        private int dIdVehiculo, dKilometraje, dExistencia;
        private string dMarca, dVIN, dModelo, dAno, dTipo, dInformaciones , dEstado;
        DateTime dFechaIngreso;
        double dPrecio;

        public CDVehiculo()
        {
        }

        public CDVehiculo(int pIdVehiculo, string pVIN, string pMarca, string pModelo, string pAno, string pTipo, int pKilometraje, DateTime pFechaIngreso, string pInformaciones, int pExistencia, double pPrecio, string pEstado)
        {
            dIdVehiculo = pIdVehiculo;
            dVIN = pVIN;
            dMarca = pMarca;
            dModelo = pModelo;
            dAno = pAno;
            dTipo = pTipo;
            dKilometraje = pKilometraje;
            dFechaIngreso = pFechaIngreso;
            dInformaciones = pInformaciones;
            dExistencia = pExistencia;
            dPrecio = pPrecio;
            dEstado = pEstado;
        }

        #region metodos get set
        public int IdVehiculo
        {
            get { return dIdVehiculo; }
            set { dIdVehiculo = value; }
        }

        public string VIN
        {
            get { return dVIN; }
            set { dVIN = value; }
        }

        public string Marca
        {
            get { return dMarca; }
            set { dMarca = value; }
        }

        public string Modelo
        {
            get { return dModelo; }
            set { dModelo = value; }
        }

        public string Ano
        {
            get { return dAno; }
            set { dAno = value; }
        }

        public string Tipo
        {
            get { return dTipo; }
            set { dTipo = value; }
        }

        public int Kilometraje
        {
            get { return dKilometraje; }
            set { dKilometraje = value; }
        }

        public DateTime FechaIngreso
        {
            get { return dFechaIngreso; }
            set { dFechaIngreso = value; }
        }

        public string Informaciones
        {
            get { return dInformaciones; }
            set { dInformaciones = value; }
        }

        public int Existencia
        {
            get { return dExistencia; }
            set { dExistencia = value; }
        }

        public double Precio
        {
            get { return dPrecio; }
            set { dPrecio = value; }
        }


        public string Estado
        {
            get { return dEstado; }
            set { dEstado = value; }
        }

        #endregion

        public string Insertar(CDVehiculo objVehiculo)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = P2Conexion.miconexion;
                SqlCommand micomando = new SqlCommand("VehiculoInsertar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pVIN", objVehiculo.VIN);
                micomando.Parameters.AddWithValue("@pMarca", objVehiculo.Marca);
                micomando.Parameters.AddWithValue("@pModelo", objVehiculo.Modelo);
                micomando.Parameters.AddWithValue("@pAno", objVehiculo.Ano);
                micomando.Parameters.AddWithValue("@pTipo", objVehiculo.Tipo);
                micomando.Parameters.AddWithValue("@pKilometraje", objVehiculo.Kilometraje);
                micomando.Parameters.AddWithValue("@pFechaIngreso", objVehiculo.FechaIngreso);
                micomando.Parameters.AddWithValue("@pInformaciones", objVehiculo.Informaciones);
                micomando.Parameters.AddWithValue("@pExistencia", objVehiculo.Existencia);
                micomando.Parameters.AddWithValue("@pPrecio", objVehiculo.Precio);
                micomando.Parameters.AddWithValue("@pEstado", objVehiculo.Estado);

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


        public string Actualizar(CDVehiculo objVehiculo)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = P2Conexion.miconexion;
                SqlCommand micomando = new SqlCommand("VehiculoActualizar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pIdVehiculo", objVehiculo.IdVehiculo);
                micomando.Parameters.AddWithValue("@pVIN", objVehiculo.VIN);
                micomando.Parameters.AddWithValue("@pMarca", objVehiculo.Marca);
                micomando.Parameters.AddWithValue("@pModelo", objVehiculo.Modelo);
                micomando.Parameters.AddWithValue("@pAno", objVehiculo.Ano);
                micomando.Parameters.AddWithValue("@pTipo", objVehiculo.Tipo);
                micomando.Parameters.AddWithValue("@pKilometraje", objVehiculo.Kilometraje);
                micomando.Parameters.AddWithValue("@pFechaIngreso", objVehiculo.FechaIngreso);
                micomando.Parameters.AddWithValue("@pInformaciones", objVehiculo.Informaciones);
                micomando.Parameters.AddWithValue("@pExistencia", objVehiculo.Existencia);
                micomando.Parameters.AddWithValue("@pPrecio", objVehiculo.Precio);
                micomando.Parameters.AddWithValue("@pEstado", objVehiculo.Estado);

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


        public DataTable VehiculoConsultar(String parametro)
        {
            DataTable dt = new DataTable(); //Se Crea DataTable que tomará los datos de los Suplidores 
            SqlDataReader leerDatos; //Creamos el DataReader 
            try
            {
                SqlCommand sqlCmd = new SqlCommand(); //Establecer el comando 
                sqlCmd.Connection = new P2Conexion().dbconexion; //Conexión que va a usar el comando 
                sqlCmd.Connection.Open(); //Se abre la conexión 
                sqlCmd.CommandText = "VehiculoConsultar"; //Nombre del Proc. Almacenado a usar 
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

