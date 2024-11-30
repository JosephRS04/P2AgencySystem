using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using CapaNegocios;


namespace CapaPresentacion
{
    public partial class FMantVehiculo : Form
    {
        public string valorparametro = "", mensaje = "";
        public FMantVehiculo()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void LimpiaObjetos()
        {
            tbIdVehiculo.Clear();
            tbVIN.Clear();
            tbMarca.Clear();
            tbModelo.Clear();
            tbAno.Clear();
            tbTipo.Clear();
            tbKilometraje.Clear();
            dateTimePickerFechaIngreso.ResetText();
            tbInformaciones.Clear();
            tbExistencia.Clear();
            tbPrecio.Clear();
            cbEstado.SelectedItem = 0;
        }// fin metodo limpiar objeto

        private void HabilitaControles(bool valor)
        {
            tbIdVehiculo.ReadOnly = true;
            tbVIN.Enabled = valor;
            tbMarca.Enabled = valor;
            tbModelo.Enabled = valor;
            tbAno.Enabled = valor;
            tbTipo.Enabled = valor;
            tbKilometraje.Enabled = valor;
            dateTimePickerFechaIngreso.Enabled = valor;
            tbInformaciones.Enabled = valor;
            tbExistencia.Enabled = valor;
            tbPrecio.Enabled = valor;
            cbEstado.Enabled = valor;

            if (Program.nuevo)
                cbEstado.SelectedIndex = 0;
        }// fin metodo habilitar controles

        private void HabilitaBotones()
        {
            if (Program.nuevo || Program.modificar)
            {
                HabilitaControles(true);
                bAgregar.Enabled = false;
                bGuardar.Enabled = true;
                bEditar.Enabled = true;
                bBuscar.Enabled = false;
                bCancelar.Enabled = true;
            }
            else
            {
                HabilitaControles(false);
                bAgregar.Enabled = true;
                bGuardar.Enabled = false;
                bEditar.Enabled = false;
                bBuscar.Enabled = true;
                bCancelar.Enabled = false;
            }

        }// fin metodo habilitar botones

        private void bmenu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            LimpiaObjetos();
            Program.nuevo = true;
            Program.modificar = false;
            HabilitaBotones();
            tbMarca.Focus();
        }

        private void FMantVehiculo_Load(object sender, EventArgs e)
        {
            Program.nuevo = false;           
            Program.modificar = false;
            HabilitaBotones();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            HabilitaBotones();  
            LimpiaObjetos();   
        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            if (!tbIdVehiculo.Equals(""))
            {
                Program.modificar = true;  
                HabilitaBotones();
            }
            else
            {
                MessageBox.Show("Debe de buscar un vehiculo registrado para poder Modificar sus datos!");
            }
        }

        private void FMantVehiculo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            FBuscarVehiculo fBuscarVehiculo = new FBuscarVehiculo(); 
            fBuscarVehiculo.ShowDialog(); 
            if (Program.modificar)
            {
                RecuperaDatos(); //Llamo al método para recuperar el Depto seleccionado 
                bEditar_Click(sender, e);  //Llamo al método editar 
            }
            else
            {
                LimpiaObjetos(); //Llama al método LimpiaObjetos 
                bBuscar.Focus();
            }
        }// fin boton buscar

        public void RecuperaDatos()
        {
            string vparametro = Program.vidVehiculo.ToString();
            CNVehiculo cNVehiculo = new CNVehiculo();
            DataTable dt = new DataTable();
            dt = cNVehiculo.ObtenerVehiculo(vparametro);
            foreach (DataRow row in dt.Rows)
            {
                tbIdVehiculo.Text = row["IdVehiculo"].ToString();
                tbVIN.Text = row["VIN"].ToString();
                tbMarca.Text = row["Marca"].ToString();
                tbModelo.Text = row["Modelo"].ToString();
                tbAno.Text = row["Ano"].ToString();
                tbTipo.Text = row["Tipo"].ToString();
                tbKilometraje.Text = row["Kilometraje"].ToString();
                dateTimePickerFechaIngreso.Text = row["FechaIngreso"].ToString();
                tbInformaciones.Text = row["Informaciones"].ToString();
                tbExistencia.Text = row["Existencia"].ToString();
                tbPrecio.Text = row["Precio"].ToString();
                cbEstado.Text = row["Estado"].ToString();
            }




        }// fin metodo recuperar datos

        private void tbIdVehiculo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbIdVehiculo_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void FMantVehiculo_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            if (tbMarca.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar el modelo del vehiculo");
                tbMarca.Focus();
            }
            else if (tbModelo.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar el modelo del vehiculo");
                tbModelo.Focus();
            }
            else if (tbAno.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar el Año del vehiculo");
                tbAno.Focus();
            }
            else if (tbVIN.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar codigo de chasis (VIN) del vehiculo");
                tbVIN.Focus();
            }
            else if (tbTipo.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar el tipo de vehiculo");
                tbTipo.Focus();
            }
            else if (tbKilometraje.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar el kilometraje del vehiculo");
                tbKilometraje.Focus();
            }
            else if (dateTimePickerFechaIngreso.Value == DateTime.MinValue)
            {
                MessageBox.Show("Debe indicar el año de ingreso del vehiculo");
                dateTimePickerFechaIngreso.Focus();
            }
            else if (tbExistencia.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar La existencia del vehiculo");
                tbExistencia.Focus();
            }
            else if (tbPrecio.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar el precio del vehiculo");
                tbPrecio.Focus();
            }
            else if (cbEstado.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar el estado del vehiculo");
                cbEstado.Focus();
            }
            else 
            {
                if (Program.nuevo)
                {
                    mensaje = CNVehiculo.Insertar(Program.vidVehiculo, tbVIN.Text, tbMarca.Text, tbModelo.Text, tbAno.Text, tbTipo.Text, int.Parse(tbKilometraje.Text), dateTimePickerFechaIngreso.Value, tbInformaciones.Text, int.Parse(tbExistencia.Text), float.Parse(tbPrecio.Text), cbEstado.Text);
                }
                else
                {
                    mensaje = CNVehiculo.Actualizar(Program.vidVehiculo, tbVIN.Text, tbMarca.Text, tbModelo.Text, tbAno.Text, tbTipo.Text, int.Parse(tbKilometraje.Text), dateTimePickerFechaIngreso.Value, tbInformaciones.Text, int.Parse(tbExistencia.Text), float.Parse(tbPrecio.Text), cbEstado.Text);
                }

                MessageBox.Show(mensaje, "Mensage de P2Systems", MessageBoxButtons.OK,MessageBoxIcon.Information);
                Program.nuevo = false;
                Program.modificar = false;
                HabilitaBotones();  
                LimpiaObjetos();
            }//Fin del else para validar los datos 


        }
    }
}


