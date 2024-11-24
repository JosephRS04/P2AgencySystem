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
    public class CNCliente
    {
        // Método para insertar un nuevo cliente 
        public static string Insertar(int pIdCliente, string pNombre, string pApellido, string pIdentificacion, string pDireccion, string pTelefono, string pEstado)
        {
            CDCliente objCliente = new CDCliente();
            objCliente.IdCliente = pIdCliente;
            objCliente.Nombre = pNombre;
            objCliente.Apellido = pApellido;
            objCliente.Identificacion = pIdentificacion;
            objCliente.Direccion = pDireccion;
            objCliente.Telefono = pTelefono;
            objCliente.Estado = pEstado;

            return objCliente.Insertar(objCliente);
        }


        // Método para actualizar un cliente existente 
        public static string Actualizar(int pIdCliente, string pNombre, string pApellido, string pIdentificacion, string pDireccion, string pTelefono, string pEstado)
        {
            CDCliente objCliente = new CDCliente();
            objCliente.IdCliente = pIdCliente;
            objCliente.Nombre = pNombre;
            objCliente.Apellido = pApellido;
            objCliente.Identificacion = pIdentificacion;
            objCliente.Direccion = pDireccion;
            objCliente.Telefono = pTelefono;
            objCliente.Estado = pEstado;

            return objCliente.Actualizar(objCliente);
        }


        // Método para obtener los clientes 
        public DataTable ObtenerCliente(string parametro)
        {
            CDCliente objCliente = new CDCliente();
            DataTable dt = new DataTable();

            dt = objCliente.ClienteConsultar(parametro);

            return dt;
        }
    }
}

