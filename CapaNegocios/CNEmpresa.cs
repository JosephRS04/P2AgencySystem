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
    public class CNEmpresa
    {
        public static string Insertar(int pidEmpresa, string pNombreEmp, string pDireccion, string pTelefono,
       string pCorreo, string pRNC, string pGerente, string pSlogan)
        {
            CDEmpresa objEmpresa = new CDEmpresa();
            objEmpresa.IdEmpresa = pidEmpresa;
            objEmpresa.NombreEmp = pNombreEmp;
            objEmpresa.Direccion = pDireccion;
            objEmpresa.Telefono = pTelefono;
            objEmpresa.Correo = pCorreo;
            objEmpresa.Slogan = pSlogan;
            objEmpresa.RNC = pRNC;
            objEmpresa.Gerente = pGerente;

            return objEmpresa.Insertar(objEmpresa);

        }

        public static string Actualizar(int pIdEmpresa, string pNombreEmp,
        string pDireccion, string pTelefono, string pCorreo, string pSlogan, string pRNC, string pGerente)
        {
            CDEmpresa objEmpresa = new CDEmpresa();
            objEmpresa.IdEmpresa = pIdEmpresa;
            objEmpresa.NombreEmp = pNombreEmp;
            objEmpresa.Direccion = pDireccion;
            objEmpresa.Telefono = pTelefono;
            objEmpresa.Correo = pCorreo;
            objEmpresa.Slogan = pSlogan;
            objEmpresa.RNC = pRNC;
            objEmpresa.Gerente = pGerente;

            return objEmpresa.Actualizar(objEmpresa);
        }

        public DataTable ObtenerEmpresa(string parametro)
        {
            CDEmpresa objEmpresa = new CDEmpresa();
            DataTable dt = new DataTable();

            dt = objEmpresa.EmpresaConsultar(parametro);

            return dt;

        } // fin metodo ObtenerEmpresa


    }
}

