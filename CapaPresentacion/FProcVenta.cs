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
using CapaNegocios;

namespace CapaPresentacion
{

    public partial class FProcVenta : Form
    {
        public static int vIdVehiculo = 0, vExistencia = 0, vCantidad = 0, vReorden = 0;
        public static string vVehiculo;
        public static double vPrecio;
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tbVehiculo_TextChanged(object sender, EventArgs e)
        {

        }

        private void FProcVenta_Load(object sender, EventArgs e)
        {

        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            vIdVehiculo = 0;
            FBuscarVehiculo fbvehiculo = new FBuscarVehiculo();
            fbvehiculo.ShowDialog();
            if (Program.modificar)
            {
                MostrarMercancia();
                tbCantidad.Focus();
            }
            else
            {
                MessageBox.Show("No eligio ninguna mercancia!");
                bBuscarVehiculo.Focus();
            }
        }

        private void bBuscarCliente_Click(object sender, EventArgs e)
        {
            FBuscarCliente fbcliente = new FBuscarCliente();
            fbcliente.ShowDialog();
            if (Program.modificar)
            {
                MostrarCliente();
                tbCantidad.Focus();
            }
            else
            {
                MessageBox.Show("No eligio ninguna mercancia!");
                bBuscarCliente.Focus();
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            tbNCF.Focus();
        }

        private void tbCantidad_Leave(object sender, EventArgs e)
        {
            if (tbCantidad.Text != string.Empty)
            {
                vCantidad = Convert.ToInt32(tbCantidad.Text);
                if (vCantidad > vExistencia)
                {
                    MessageBox.Show("No hay suficiente existencia de la mercancia indicada!");
                    tbCantidad.Focus();
                }
                else
                {
                    tbPrecio.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debe indicar la cantidad vendida!");
                tbCantidad.Focus();
            }
        }

        private void Limpiar()
        {
            //textbox
            tbIdVehiculo.Text = string.Empty;
            tbVehiculo.Text = string.Empty;
            tbNCF.Text = string.Empty;
            tbCondicion.Text = string.Empty;
            tbCantidad.Text = string.Empty;
            tbUnidad.Text = string.Empty;
            tbPrecio.Text = string.Empty;
            tbIdCliente.Text = string.Empty;
            tbIdCliente.Text = string.Empty;
            tbIdEmpleado.Text = string.Empty;
            tbIdEmpleado.Text = string.Empty;
            //combobox y fecha
            cbTipofactura.Text = string.Empty;
            cbEstado.Text = string.Empty;
            //labels
            lbSubTotal.Text = "Sub-Total: ";
            lbItebis.Text = "18% Itbis: ";
            lbTotal.Text = "Total: ";
            //variables
            vIdVehiculo = 0; vExistencia = 0; vCantidad = 0;
            vVehiculo = ""; vPrecio = 0.00; //vReorden = 0;
            selecciono = false;
        }// fin metodo limpiar

        private void tbCondicion_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbTipofactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipofactura.Text == "Credito")
            {
                tbCondicion.Enabled = true;
            }
            else
            {
                tbCondicion.Enabled = false;
            }
        }

        private void MostrarCliente()
        {
            string vparametro = Program.vidCliente.ToString();
            CNCliente cNCliente = new CNCliente();
            DataTable dt = new DataTable();
            dt = cNCliente.ObtenerCliente(vparametro);
            foreach (DataRow row in dt.Rows)
            {
                tbIdCliente.Text = row["IdCliente"].ToString();
                tbCliente.Text = row["Nombre"].ToString()+" "+row["Apellido"].ToString();
            }
        }


        private void MostrarMercancia()
        {
            SqlConnection mi_conexion = new SqlConnection(miconexion);
            try
            {
                SqlCommand miinstruccion = mi_conexion.CreateCommand();
                miinstruccion.CommandText = "Select IdVehiculo, Existencia, Precio, Marca, Modelo From Vehiculo Where IDVehiculo = "+Convert.ToInt32(Program.vidVehiculo);   
                mi_conexion.Open();
                //creamos el objeto datareader 
                SqlDataReader midatareader = miinstruccion.ExecuteReader();
                //Leer la fila devuelta usando el obejto SqlDataReader 
                midatareader.Read();
                //Pasar los valores a las variables 
                vVehiculo = Convert.ToString(midatareader["IdVehiculo"]);
                vExistencia = Convert.ToInt32(midatareader["Existencia"]);
                vPrecio = Convert.ToDouble(midatareader["Precio"]);
                //vReorden = Convert.ToInt32(midatareader["Nivel_Reorden"]);
                //Mostrar los valores de las columnas contenidas en el Objeto SqlDataReader 
                tbIdVehiculo.Text = Convert.ToString(midatareader["IdVehiculo"]);
                tbVehiculo.Text = Convert.ToString(midatareader["Marca"])+" "+ Convert.ToString(midatareader["Modelo"]);
                tbExistencia.Text = Convert.ToString(midatareader["Existencia"]);
                tbPrecio.Text = Convert.ToString(midatareader["Precio"]);
                tbExistencia.Text = Convert.ToString(midatareader["Existencia"]);
                //tbreorden.Text = Convert.ToString(midatareader["Nivel_Reorden"]);
                //Cerrar el Objeto SqlDataReader al terminar de usarlo 
                midatareader.Close();
                mi_conexion.Close();
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
