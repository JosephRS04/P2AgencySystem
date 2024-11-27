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
    public class CNVehiculo
    {
        public static string Insertar(int pIdVehiculo, string pVIN, string pMarca, string pModelo, string pAno, string pTipo, int pKilometraje, DateTime pFechaIngreso, string pInformaciones, int pExistencia, float pPrecio, string pEstado)
        {
            CDVehiculo objVehiculo = new CDVehiculo();
            objVehiculo.IdVehiculo = pIdVehiculo;
            objVehiculo.VIN = pVIN;
            objVehiculo.Marca = pMarca;
            objVehiculo.Modelo = pModelo;
            objVehiculo.Ano = pAno;
            objVehiculo.Tipo = pTipo;
            objVehiculo.Kilometraje = pKilometraje;
            objVehiculo.FechaIngreso = pFechaIngreso;
            objVehiculo.Informaciones = pInformaciones;
            objVehiculo.Existencia = pExistencia;
            objVehiculo.Precio = pPrecio;
            objVehiculo.Estado = pEstado;

            return objVehiculo.Insertar(objVehiculo);
        }// fin metodo insertar

        public static string Actualizar(int pIdVehiculo, string pVIN, string pMarca, string pModelo, string pAno, string pTipo, int pKilometraje, DateTime pFechaIngreso, string pInformaciones, int pExistencia, float pPrecio, string pEstado)
        {
            CDVehiculo objVehiculo = new CDVehiculo();
            objVehiculo.IdVehiculo = pIdVehiculo;
            objVehiculo.VIN = pVIN;
            objVehiculo.Marca = pMarca;
            objVehiculo.Modelo = pModelo;
            objVehiculo.Ano = pAno;
            objVehiculo.Tipo = pTipo;
            objVehiculo.Kilometraje = pKilometraje;
            objVehiculo.FechaIngreso = pFechaIngreso;
            objVehiculo.Informaciones = pInformaciones;
            objVehiculo.Existencia = pExistencia;
            objVehiculo.Precio = pPrecio;
            objVehiculo.Estado = pEstado;

            return objVehiculo.Actualizar(objVehiculo);
        }// fin metodo Actualizar


        public DataTable ObtenerVehiculo(string parametro)
        {
            CDVehiculo objVehiculo = new CDVehiculo();
            DataTable dt = new DataTable();

            dt = objVehiculo.VehiculoConsultar(parametro);

            return dt;
        } // fin metodo ObtenerVehiculo


    }
}
