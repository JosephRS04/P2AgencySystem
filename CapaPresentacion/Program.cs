using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public static class Program
    {
        public static int vidCliente = 0;

        public static int vidVehiculo = 0;

        public static int vidEmpleado = 0;

        public static int vidEmpresa = 0;

        public static int vidRol = 0;

        public static int vidUsuario = 0;

        public static int vidVentaCabecera = 0;

        public static int vidVentaDetalle = 0;

        public static bool nuevo = false;

        public static bool modificar = false;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
