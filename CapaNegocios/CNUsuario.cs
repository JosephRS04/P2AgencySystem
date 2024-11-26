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
    public class CNUsuario
    {
        public static string Insertar(int pIdUsuario, string pUsuario, string pClave, int pIdEmpleado, int pIdRol, string pEstado)
        {
            CDUsuario objUsuario = new CDUsuario();
            objUsuario.IdUsuario = pIdUsuario;
            objUsuario.Usuario = pUsuario;
            objUsuario.Clave = pClave;
            objUsuario.IdEmpleado = pIdEmpleado;
            objUsuario.IdRol = pIdRol;
            objUsuario.Estado = pEstado;

            return objUsuario.Insertar(objUsuario);
        }

        public static string Actualizar(int pIdUsuario, string pUsuario, string pClave, int pIdEmpleado, int pIdRol, string pEstado)
        {
            CDUsuario objUsuario = new CDUsuario();
            objUsuario.IdUsuario = pIdUsuario;
            objUsuario.Usuario = pUsuario;
            objUsuario.Clave = pClave;
            objUsuario.IdEmpleado = pIdEmpleado;
            objUsuario.IdRol = pIdRol;
            objUsuario.Estado = pEstado;

            return objUsuario.Actualizar(objUsuario);
        }

        public DataTable ObtenerCliente(string parametro)
        {
            CDUsuario objUsuario = new CDUsuario();
            DataTable dt = new DataTable();

            dt = objUsuario.UsuarioConsultar(parametro);

            return dt;
        }

    }
}
