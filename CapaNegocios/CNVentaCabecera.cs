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
    public class CNVentaCabecera
    {
        public static string Insertar(int pIdVentaCabecera, DateTime pFecha, int pIdCliente, int pIdEmpleado, String pNCF, string pTipoFactura, int pCondicion, string pEstado)
        {
            CDVentaCabecera objVentaCabecera = new CDVentaCabecera();
            objVentaCabecera.IdVentaCabecera = pIdVentaCabecera;
            objVentaCabecera.Fecha = pFecha;
            objVentaCabecera.IdCliente = pIdCliente;
            objVentaCabecera.IdEmpleado = pIdEmpleado;
            objVentaCabecera.NCF = pNCF;
            objVentaCabecera.TipoFactura = pTipoFactura;
            objVentaCabecera.Condicion = pCondicion;
            objVentaCabecera.Estado = pEstado;

            return objVentaCabecera.Insertar(objVentaCabecera);
        }// fin metodo insertar 


        public static string Actualizar(int pIdVentaCabecera, DateTime pFecha, int pIdCliente, int pIdEmpleado, String pNCF, string pTipoFactura, int pCondicion, string pEstado)
        {
            CDVentaCabecera objVentaCabecera = new CDVentaCabecera();
            objVentaCabecera.IdVentaCabecera = pIdVentaCabecera;
            objVentaCabecera.Fecha = pFecha;
            objVentaCabecera.IdCliente = pIdCliente;
            objVentaCabecera.IdEmpleado = pIdEmpleado;
            objVentaCabecera.NCF = pNCF;
            objVentaCabecera.TipoFactura = pTipoFactura;
            objVentaCabecera.Condicion = pCondicion;
            objVentaCabecera.Estado = pEstado;

            return objVentaCabecera.Actualizar(objVentaCabecera);
        }// fin metodo Actualizar 


        public DataTable ObtenerVentaCabecera(string parametro)
        {
            CDVentaCabecera objVentaCabecera = new CDVentaCabecera();
            DataTable dt = new DataTable();

            dt = objVentaCabecera.VentaCabeceraConsultar(parametro);

            return dt;
        } // fin metodo ObtenerVehiculo 

    }

}