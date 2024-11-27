using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CapaPresentacion
{

    public partial class FProcVenta : Form
    {
        public static int vidmercancia = 0, vexistencia = 0, vcantidad = 0, vreorden = 0;
        public static string vmercancia;
        public static double vprecio;
        public static bool selecciono = false;

        private void bmenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        public static string miconexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\JRProgramaciones\P2AgencySystem\CapaDatos\DBAgencySystem.mdf;Integrated Security=True";

        public FProcVenta()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            //textbox
            tbVehiculo.Text = string.Empty;
            tbNCF.Text = string.Empty;
            tbCondicion.Text = string.Empty;
            tbCantidad.Text = string.Empty;
            tbUnidad.Text = string.Empty;
            tbPrecio.Text = string.Empty;
            tbCliente.Text = string.Empty;
            tbEmpleado.Text = string.Empty;
            //combobox y fecha
            cbTipofactura.Text = string.Empty;
            cbEstado.Text = string.Empty;
            //labels
            lbSubTotal.Text = "Sub-Total: ";
            lbItebis.Text = "18% Itbis: ";
            lbTotal.Text = "Total: ";
            //variables
            vidmercancia = 0; vexistencia = 0; vcantidad = 0;
            vmercancia = ""; vprecio = 0.00; vreorden = 0;
            selecciono = false;
        }// fin metodo limpiar

        private void MostrarMercancia()
        {
            try
            {
                //SqlCommand miinstruccion = miconexion.CreateCommand();
                //miinstruccion.CommandText = "Select IdVehiculo, VIN, PrecioVenta,"+"Nivel_Reorden From Mercancia Where IDVehiculo = "+Convert.ToInt32(vidmercancia);   
                //mi_conexion.Open();
                //creamos el objeto datareader 
                //SqlDataReader midatareader = miinstruccion.ExecuteReader();
                //Leer la fila devuelta usando el obejto SqlDataReader 
                //midatareader.Read();
                //Pasar los valores a las variables 
                //vmercancia = Convert.ToString(midatareader["Mercancia"]);
                //vexistencia = Convert.ToInt32(midatareader["Existencia"]);
                //vprecio = Convert.ToDouble(midatareader["PrecioVenta"]);
                //vreorden = Convert.ToInt32(midatareader["Nivel_Reorden"]);
                //Mostrar los valores de las columnas contenidas en el Objeto        
                //SqlDataReader 
                //tbidmercancia.Text = Convert.ToString(midatareader["IDMercancia"]);
                //tbmercancia.Text = Convert.ToString(midatareader["Mercancia"]);
                //tbprecioventa.Text = Convert.ToString(midatareader["PrecioVenta"]);
                //tbexistencia.Text = Convert.ToString(midatareader["Existencia"]);
                //tbreorden.Text = Convert.ToString(midatareader["Nivel_Reorden"]);
                //Cerrar el Objeto SqlDataReader al terminar de usarlo 
                //MessageBox.Show("2");
                //midatareader.Close();
                //mi_conexion.Close();
            } 
            catch 
            { 
                MessageBox.Show("Ocurrió un error al realizar la operación solicitada! "); 
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

    }// fin clase FProcVenta
}
