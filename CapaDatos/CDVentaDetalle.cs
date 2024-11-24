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
    public class CDVentaDetalle
    {
        private int dIdVentaDetalle, dNumFactura, dIdVehiculo, dPrecio, dCantidad;
        private string dUnidad;

        public CDVentaDetalle()
        {
        }

        public CDVentaDetalle(int pIdVentaDetalle, int pNumFactura, int pIdVehiculo, int pPrecio, int pCantidad, string pUnidad)

        {
            dIdVentaDetalle = pIdVentaDetalle;
            dNumFactura = pNumFactura;
            dIdVehiculo = pIdVehiculo;
            dPrecio = pPrecio;
            dCantidad = pCantidad;
            dUnidad = pUnidad;
        }

        #region metodos get set 

        public int IdVentaDetalle
        {
            get { return dIdVentaDetalle; }
            set { dIdVentaDetalle = value; }
        }

        public int NumFactura
        {
            get { return dNumFactura; }
            set { dNumFactura = value; }
        }

        public int IdVehiculo
        {
            get { return dIdVehiculo; }
            set { dIdVehiculo = value; }
        }

        public int Precio
        {
            get { return dPrecio; }
            set { dPrecio = value; }
        }

        public int Cantidad
        {
            get { return dCantidad; }
            set { dCantidad = value; }
        }

        public string Unidad
        {
            get { return dUnidad; }
            set { dUnidad = value; }
        }


        #endregion

        public string Insertar(CDVentaDetalle objVentaDetalle)
        {

            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = P2Conexion.miconexion;
                SqlCommand micomando = new SqlCommand("VentaDetalleInsertar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
    
                micomando.Parameters.AddWithValue("@pNumFactura", objVentaDetalle.NumFactura);
                micomando.Parameters.AddWithValue("@pIdVehiculo", objVentaDetalle.IdVehiculo);
                micomando.Parameters.AddWithValue("@pPrecio", objVentaDetalle.Precio);
                micomando.Parameters.AddWithValue("@pCantidad", objVentaDetalle.Cantidad);
                micomando.Parameters.AddWithValue("@pUnidad", objVentaDetalle.Unidad);

                mensaje = micomando.ExecuteNonQuery() == 1 ? "Insercion de datos completada correctamente" : "No se pudo insertar correctamente los datos";
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


        public string Actualizar(CDVentaDetalle objVentaDetalle)

        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = P2Conexion.miconexion;
                SqlCommand micomando = new SqlCommand("VentaDetalleActualizar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pIdVentaDetalle", objVentaDetalle.IdVentaDetalle);
                micomando.Parameters.AddWithValue("@pNumFactura", objVentaDetalle.NumFactura);
                micomando.Parameters.AddWithValue("@pIdVehiculo", objVentaDetalle.IdVehiculo);
                micomando.Parameters.AddWithValue("@pPrecio", objVentaDetalle.Precio);
                micomando.Parameters.AddWithValue("@pCantidad", objVentaDetalle.Cantidad);
                micomando.Parameters.AddWithValue("@pUnidad", objVentaDetalle.Unidad);

                mensaje = micomando.ExecuteNonQuery() == 1 ? "Actualizacion de datos completada correctamente" :
                    "No se pudo actualizar correctamente los datos!";
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


        public DataTable VentaDetalleConsultar(String parametro)
        {
            DataTable dt = new DataTable();
            SqlDataReader leerDatos;
            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = new P2Conexion().dbconexion;
                sqlCmd.Connection.Open();
                sqlCmd.CommandText = "VentaDetalleConsultar";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pvalor", parametro);
                leerDatos = sqlCmd.ExecuteReader();
                dt.Load(leerDatos);
                sqlCmd.Connection.Close();
            }
            catch (Exception ex)
            {
                dt = null;
            }
            return dt;


        }

    }

}

