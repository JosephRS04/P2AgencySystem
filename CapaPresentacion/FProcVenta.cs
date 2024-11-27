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
        public static int vIdVehiculo = 0, vExistencia = 0, vCantidad = 0, vReorden = 0, vNewExistencia=0;
        public static string vVehiculo, valorparametro = "", mensaje = "";
        public static double vPrecio, subTotalVenta = 0, itbisVenta = 0, totalVenta = 0;
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
                    tbCantidad.Text = "0";
                    tbCantidad.Focus();
                }
                else
                {
                    tbPrecio.Focus();
                }// fin if cantidad mas que existencia
            }
            else
            {
                MessageBox.Show("Debe indicar la cantidad vendida!");
                tbCantidad.Focus();
            }// fin if cantidad no esta vacio

        }// fin ,etodo cantidad leave

        private void Limpiar()
        {
            //textbox
            tbIdVenta.Text = string.Empty;
            tbIdVehiculo.Text = string.Empty;
            tbVehiculo.Text = string.Empty;
            tbExistencia.Text = string.Empty;
            tbNCF.Text = string.Empty;
            tbCondicion.Text = string.Empty;
            tbCantidad.Text = string.Empty;
            tbUnidad.Text = string.Empty;
            tbPrecio.Text = string.Empty;
            tbIdCliente.Text = string.Empty;
            tbCliente.Text = string.Empty;
            tbIdEmpleado.Text = string.Empty;
            tbEmpleado.Text = string.Empty;
            //combobox y fecha
            cbTipofactura.Text = string.Empty;
            cbEstado.Text = string.Empty;
            dateTimePickerFecha.ResetText();
            //labels
            lbSubTotal.Text = "Sub-Total: ";
            lbItebis.Text = "18% Itbis: ";
            lbTotal.Text = "Total: ";
            //variables
            vIdVehiculo = 0; vExistencia = 0; vCantidad = 0;
            vVehiculo = ""; vPrecio = 0.00; //vReorden = 0;
            selecciono = false;
        }// fin metodo limpiar

        private void tbCantidad_TextChanged(object sender, EventArgs e)
        {
            calcularVenta();
        }

        private void tbCondicion_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPrecio_TextChanged(object sender, EventArgs e)
        {
            calcularVenta();
        }

        private int ObtenerNumeroRandom()
        {
            HashSet<int> numerosExistentes = new HashSet<int>();
            using (SqlConnection miConexion = new SqlConnection(miconexion))
            {
                SqlCommand miInstruccion = new SqlCommand("SELECT NumFactura FROM VentaDetalle", miConexion);
                miConexion.Open();

                using (SqlDataReader miDataReader = miInstruccion.ExecuteReader())
                {
                    while (miDataReader.Read())
                    {
                        // Agregar los valores existentes al HashSet
                        numerosExistentes.Add(Convert.ToInt32(miDataReader["NumFactura"]));
                    }
                }
            }

            // Instancia de Random fuera del bucle para evitar repeticiones
            Random random = new Random();
            int numeroRecibo;
            do
            {
                numeroRecibo = random.Next(100000, 999999); // Genera un número de 6 dígitos
            }
            while (numerosExistentes.Contains(numeroRecibo));

            return numeroRecibo;
        }


        private void calcularVenta()
        {
            if (tbPrecio.Text != string.Empty & tbCantidad.Text != string.Empty)
            {
                vCantidad = Convert.ToInt32(tbCantidad.Text);
                vPrecio = Convert.ToDouble(tbPrecio.Text);
                vExistencia = Convert.ToInt32(tbExistencia.Text);

                subTotalVenta = vPrecio * vCantidad;
                lbSubTotal.Text = "Sub-Total: $" + subTotalVenta;

                itbisVenta = subTotalVenta * 0.18;
                lbItebis.Text = "18% Itbis: $" + itbisVenta;

                totalVenta = subTotalVenta - itbisVenta;
                lbTotal.Text = "Total: $" + totalVenta;

                vNewExistencia = vExistencia - vCantidad;
            }
            else
            {
                lbSubTotal.Text = "Sub-Total: ";
                lbItebis.Text = "18% Itbis: ";
                lbTotal.Text = "Total: ";
            }
        }

        private void cbTipofactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipofactura.Text == "Credito")
            {
                tbCondicion.Enabled = true;
                labelCondicion.Text = "dias para pagar";
            }
            else
            {
                tbCondicion.Enabled = false;
                labelCondicion.Text = "";
            }
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            if (tbNCF.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar el NCF del vehiculo");
                tbNCF.Focus();
            }
            else if (cbTipofactura.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar el Tipo de factura del vehiculo");
                cbTipofactura.Focus();
            }
            else if (tbCantidad.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar la cantidad de vehiculos a vender");
                tbCantidad.Focus();
            }
            else if (tbUnidad.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar la unidad de venta");
                tbUnidad.Focus();
            }
            else if (tbPrecio.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar el Precio del vehiculo");
                tbPrecio.Focus();
            }
            else if (tbIdVehiculo.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar el ID del vehiculo");
                tbIdVehiculo.Focus();
            }
            else if (tbExistencia.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar la existencia del vehiculo");
                tbExistencia.Focus();
            }
            else if (tbIdCliente.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar ID del cliente que compra");
                tbIdCliente.Focus();
            }
            else if (tbIdEmpleado.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar el Id del empleado que realiza la venta");
                tbIdEmpleado.Focus();
            }
            else if (cbEstado.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar el estado del vehiculo");
                cbEstado.Focus();
            }
            else
            {
                int vNumFactura = ObtenerNumeroRandom();
                if (Program.nuevo)
                {
                    mensaje = CNVentaCabecera.Insertar(Program.vidVentaCabecera, dateTimePickerFecha.Value, Convert.ToInt32(tbIdCliente.Text), Convert.ToInt32(tbIdEmpleado.Text), tbNCF.Text, cbTipofactura.Text, Convert.ToInt32(tbCondicion.Text), cbEstado.Text);
                    mensaje = CNVentaDetalle.Insertar(Program.vidVentaDetalle, vNumFactura, Convert.ToInt32(tbIdVehiculo.Text), Convert.ToInt32(tbPrecio.Text), Convert.ToInt32(tbCantidad.Text), tbUnidad.Text);
                    SqlConnection mi_conexion = new SqlConnection(miconexion);
                    try
                    {
                        SqlCommand miinstruccion = mi_conexion.CreateCommand();
                        miinstruccion.CommandText = "UPDATE Vehiculo SET Existencia=" + vNewExistencia + "WHERE IdVehiculo" + Convert.ToInt32(tbIdVehiculo.Text);
                        mi_conexion.Open();
                        //creamos el objeto datareader 
                        SqlDataReader midatareader = miinstruccion.ExecuteReader();
                        //Leer la fila devuelta usando el obejto SqlDataReader 
                        midatareader.Read();
                    }
                    catch
                    {
                        MessageBox.Show("Ocurrió un error al realizar la operación de actualizar existencia! ");
                    }
                }
                else
                {
                    mensaje = CNVentaCabecera.Actualizar(Program.vidVentaCabecera, dateTimePickerFecha.Value, Convert.ToInt32(tbIdCliente.Text), Convert.ToInt32(tbIdEmpleado.Text), tbNCF.Text, cbTipofactura.Text, Convert.ToInt32(tbCondicion.Text), cbEstado.Text);
                    mensaje = CNVentaDetalle.Actualizar(Program.vidVentaDetalle, vNumFactura, Convert.ToInt32(tbIdVehiculo.Text), Convert.ToInt32(tbPrecio.Text), Convert.ToInt32(tbCantidad.Text), tbUnidad.Text);
                }

                MessageBox.Show(mensaje, "Mensage de P2Systems", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.nuevo = false;
                Program.modificar = false;
                Limpiar();
            }//Fin del else para validar los datos 
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
