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
    public class CNEmpleado
    {
        public static string Insertar(int pIdEmpleado, string pNombre, string pApellido, string pTelefono, DateTime pFechaNacimiento, int pIdRol, string pEstado)
        {
            CDEmpleado objEmpleado = new CDEmpleado();
            objEmpleado.IdEmpleado = pIdEmpleado;
            objEmpleado.Nombre = pNombre;
            objEmpleado.Apellido = pApellido;
            objEmpleado.Telefono = pTelefono;
            objEmpleado.FechaNacimiento = pFechaNacimiento;
            objEmpleado.IdRol = pIdRol;
            objEmpleado.Estado = pEstado;

            return objEmpleado.Insertar(objEmpleado);
        }

        public static string Actualizar(int pIdEmpleado, string pNombre, string pApellido, string pTelefono, DateTime pFechaNacimiento, int pIdRol, string pEstado)
        {
            CDEmpleado objEmpleado = new CDEmpleado();
            objEmpleado.IdEmpleado = pIdEmpleado;
            objEmpleado.Nombre = pNombre;
            objEmpleado.Apellido = pApellido;
            objEmpleado.Telefono = pTelefono;
            objEmpleado.FechaNacimiento = pFechaNacimiento;
            objEmpleado.IdRol = pIdRol;
            objEmpleado.Estado = pEstado;

            return objEmpleado.Actualizar(objEmpleado);
        }

        public DataTable ObtenerEmpleado(string parametro)
        {
            CDEmpleado objEmpleado = new CDEmpleado();
            DataTable dt = new DataTable();

            dt = objEmpleado.EmpleadoConsultar(parametro);

            return dt;
        }

    }
}
