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
    public class CNRol
    {
        public static string Insertar(int pidRol, string pFuncionRol, string pEstado)
        {
            CDRol objRol = new CDRol();
            objRol.IdRol = pidRol;
            objRol.FuncionRol = pFuncionRol;
            objRol.Estado = pEstado;
            
            return objRol.Insertar(objRol);

        }

        public static string Actualizar(int pIdRol, string pFuncionRol, string pEstado)
        {
            CDRol objRol = new CDRol();
            objRol.IdRol = pIdRol;
            objRol.FuncionRol = pFuncionRol;
            objRol.Estado = pEstado;

            return objRol.Actualizar(objRol);
        }

        public DataTable ObtenerRol(string parametro)
        {
            CDRol objRol = new CDRol();
            DataTable dt = new DataTable();

            dt = objRol.RolConsultar(parametro);

            return dt;
        } // fin metodo ObtenerEmpresa

    }
}
