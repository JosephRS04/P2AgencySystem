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
    public partial class FMantEmpleado : Form
    {
        public string valorparametro = "", mensaje = "";

        public FMantEmpleado()
        {
            InitializeComponent();
        }

        private void FMantEmpleado_Load(object sender, EventArgs e)
        {
            string vparametro = "";
            CNRol objRol = new CNRol();
            tbIdRol.DataSource = objRol.ObtenerRol(vparametro);
            tbIdRol.DisplayMember = "FuncionRol";
            tbIdRol.ValueMember = "IdRol";
            tbIdRol.SelectedIndex = 0;
            string vRol = tbIdRol.Text;
            int vIdRol = Convert.ToInt32(tbIdRol.SelectedValue);

            Program.nuevo = false;
            Program.modificar = false;
            HabilitaBotones();
        }

        private void cbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void LimpiaObjetos()
        {
            tbIdEmpleado.Clear();
            tbNombre.Clear();
            tbApellido.Clear();
            tbTelefono.Clear();
            dateTimePickerFechaNacimiento.ResetText();
            tbIdRol.SelectedItem = 0;
            cbEstado.SelectedItem = 0;
        }// fin metodo limpiar objeto


        private void HabilitaControles(bool valor)
        {
            tbIdEmpleado.ReadOnly = true;
            tbNombre.Enabled = valor;
            tbApellido.Enabled = valor;
            tbTelefono.Enabled = valor;
            dateTimePickerFechaNacimiento.Enabled = valor;
            tbIdRol.Enabled = valor;
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
                bEditar.Enabled = false;
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

        private void FMantVehiculo_Load(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            HabilitaBotones();
        }

        private void FMantEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        public void RecuperaDatos()
        {
            string vparametro = Program.vidEmpleado.ToString();
            CNEmpleado cNEmpleado = new CNEmpleado();
            DataTable dt = new DataTable();
            dt = cNEmpleado.ObtenerEmpleado(vparametro);
            if (dt.Rows.Count <= 0) 
            {
                MessageBox.Show("No tiene registros");
            }
            foreach (DataRow row in dt.Rows)
            {
                tbIdEmpleado.Text = row["IdEmpleado"].ToString();
                tbNombre.Text = row["Nombre"].ToString();
                tbApellido.Text = row["Apellido"].ToString();
                tbTelefono.Text = row["Telefono"].ToString();
                dateTimePickerFechaNacimiento.Text = row["FechaNacimiento"].ToString();
                tbIdRol.Text = row["IdRol"].ToString();
                cbEstado.Text = row["Estado"].ToString();
            }

        }// fin metodo recuperar datos

        private void tbIdEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void bAgregar_Click_1(object sender, EventArgs e)
        {
            LimpiaObjetos();
            Program.nuevo = true;
            Program.modificar = false;
            HabilitaBotones();
            tbNombre.Focus();
        }

        private void bEditar_Click_1(object sender, EventArgs e)
        {
            if (!tbIdEmpleado.Equals(""))
            {
                Program.modificar = true;
                HabilitaBotones();
            }
            else
            {
                MessageBox.Show("Debe de buscar un empleado registrado para poder Modificar sus datos!");
            }
        }

        private void bCancelar_Click_1(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            HabilitaBotones();
            LimpiaObjetos();
        }

        private void bBuscar_Click_1(object sender, EventArgs e)
        {
            FBuscarEmpleado fBuscarempleado = new FBuscarEmpleado(); 
            fBuscarempleado.ShowDialog(); 
            if (Program.modificar)
            {
                RecuperaDatos();  //Llamo al método para recuperar el Depto seleccionado 
                bEditar_Click_1(sender, e);  //Llamo al método editar 
            }
            else
            {
                LimpiaObjetos(); //Llama al método LimpiaObjetos 
                bBuscar.Focus();
            }
        }

        private void bmenu_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bGuardar_Click_1(object sender, EventArgs e)
        {
            if (tbNombre.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar el Nombre del empleado");
                tbNombre.Focus();
            }
            else if (tbApellido.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar el Apellido del empleado");
                tbApellido.Focus();
            }
            else if (tbTelefono.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar Telefono del empleado");
                tbTelefono.Focus();
            }

            else if (dateTimePickerFechaNacimiento.Value == DateTime.MinValue)
            {
                MessageBox.Show("Debe indicar el año de nacimiento del empleado");
                dateTimePickerFechaNacimiento.Focus();
            }

            else if (cbEstado.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar el estado del empleado");
                cbEstado.Focus();
            }
            else if (tbIdRol.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar el Rol del empleado");
                tbIdRol.Focus();
            }
            else
            {
                if (Program.nuevo)
                {
                    mensaje = CNEmpleado.Insertar(Program.vidEmpleado, tbNombre.Text, tbApellido.Text, tbTelefono.Text,
                        dateTimePickerFechaNacimiento.Value, Convert.ToInt32(tbIdRol.SelectedValue), cbEstado.Text);
                }
                else
                {
                    mensaje = CNEmpleado.Actualizar(Program.vidEmpleado, tbNombre.Text, tbApellido.Text, tbTelefono.Text,
                        dateTimePickerFechaNacimiento.Value, Convert.ToInt32(tbIdRol.SelectedValue), cbEstado.Text);
                }

                MessageBox.Show(mensaje, "Mensage de P2Systems", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.nuevo = false;
                Program.modificar = false;
                HabilitaBotones();
                LimpiaObjetos();
            }//Fin del else para validar los datos 
        }// fin metodo guardar



    }
}
