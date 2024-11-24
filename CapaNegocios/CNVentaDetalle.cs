using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using CapaDatos;

namespace CapaNegocios
{
    public class CNVentaDetalle
    {
        public static string Insertar(int pIdVentaDetalle, int pNumFactura, int pIdVehiculo, int pPrecio, int pCantidad, string pUnidad)
        {
            CDVentaDetalle objVentaDetalle = new CDVentaDetalle();
            objVentaDetalle.IdVentaDetalle = pIdVentaDetalle;
            objVentaDetalle.NumFactura = pNumFactura;
            objVentaDetalle.IdVehiculo = pIdVehiculo;
            objVentaDetalle.Precio = pPrecio;
            objVentaDetalle.Cantidad = pCantidad;
            objVentaDetalle.Unidad = pUnidad;

            return objVentaDetalle.Insertar(objVentaDetalle);
        }// fin metodo insertar 


        public static string Actualizar(int pIdVentaDetalle, int pNumFactura, int pIdVehiculo, int pPrecio, int pCantidad, string pUnidad)
        {
            CDVentaDetalle objVentaDetalle = new CDVentaDetalle();
            objVentaDetalle.IdVentaDetalle = pIdVentaDetalle;
            objVentaDetalle.NumFactura = pNumFactura;
            objVentaDetalle.IdVehiculo = pIdVehiculo;
            objVentaDetalle.Precio = pPrecio;
            objVentaDetalle.Cantidad = pCantidad;
            objVentaDetalle.Unidad = pUnidad;

            return objVentaDetalle.Actualizar(objVentaDetalle);
        }// fin metodo Actualizar 


        public DataTable ObtenerVentaDetalle(string parametro)
        {
            CDVentaDetalle objVentaDetalle = new CDVentaDetalle();
            DataTable dt = new DataTable();

            dt = objVentaDetalle.VentaDetalleConsultar(parametro);

            return dt;
        } // fin metodo ObtenerVehiculo 

    }

}