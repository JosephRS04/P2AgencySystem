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
    public partial class FMantCliente : Form
    {
        public string valorparametro = "", mensaje = "";

        public FMantCliente()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void FMantCliente_Load(object sender, EventArgs e)
        {
            Program.nuevo = false;           //Valores de las variables globales nuevo y modificar 
            Program.modificar = false;
            HabilitaBotones();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            FBuscarCliente fBuscarCliente = new FBuscarCliente();
            fBuscarCliente.ShowDialog();
            if (Program.modificar)      //Si se está en modo de edición 
            {
                RecuperaDatos();  //Llamo al método para recuperar el registro seleccionado 
                bEditar_Click(sender, e);     //Llamo el método del botón Editar 
            }
            else          //Si no estamos en modo de edición no permite la acción. 
            {
                LimpiaObjetos(); //Llama al método LimpiaObjetos 
                bBuscar.Focus();
            }
        }

        public void RecuperaDatos()
        {
            string vparametro = Program.vidCliente.ToString();
            CNCliente cNCliente = new CNCliente();
            DataTable dt = new DataTable(); //creamos un nuevo DataTable 
            dt = cNCliente.ObtenerCliente(vparametro); //Llenamos el DataTable
            foreach (DataRow row in dt.Rows)
            {
                tbIdCliente.Text = row["IdCliente"].ToString();
                tbNombre.Text = row["Nombre"].ToString();
                tbApellido.Text = row["Apellido"].ToString();
                tbIdentificacion.Text = row["Identificacion"].ToString();
                tbDireccion.Text = row["Direccion"].ToString();
                tbTelefono.Text = row["Telefono"].ToString();
                cbEstado.Text = row["Estado"].ToString();
            }
        } //Fin del método RecuperarDatos

        private void bmenu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public void LimpiaObjetos()
        {
            tbIdCliente.Clear();
            tbNombre.Clear();
            tbApellido.Clear();
            tbIdentificacion.Clear();
            tbDireccion.Clear();
            tbTelefono.Clear();
            cbEstado.SelectedItem = 0;
        }// fin metodo limpiar objeto

        //Habilita / inhabilita los objetos del formulario segun lo indicado por el parámetro valor 
        private void HabilitaControles(bool valor)
        {
            tbIdCliente.ReadOnly = true;
            tbNombre.Enabled = valor;
            tbApellido.Enabled = valor;
            tbIdentificacion.Enabled = valor;
            tbDireccion.Enabled = valor;
            tbTelefono.Enabled = valor;
            cbEstado.Enabled = valor;
            if (Program.nuevo)
                cbEstado.SelectedIndex = 0;
        }  //Fin del método HabilitaControles

        private void bAgregar_Click(object sender, EventArgs e)
        {
            LimpiaObjetos();         //LLama al método LimpiaObjetos para prepararlos para la nueva entrada 
            Program.nuevo = true;   //Se especifica que se agregará un nuevo registro 
            Program.modificar = false;
            HabilitaBotones();   //Se habilitan solo aquellos botones que sean necesarios 
            tbNombre.Focus();
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar el nombre del cliente");
                tbNombre.Focus();
            }
            else if (tbApellido.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar el apellido del cliente");
                tbApellido.Focus();
            }
            else if (tbIdentificacion.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar la identificación del cliente");
                tbIdentificacion.Focus();
            }
            else if (tbDireccion.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar la dirección del cliente");
                tbDireccion.Focus();
            }
            else if (tbTelefono.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar el telefono del cliente");
                tbTelefono.Focus();
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
                    mensaje = CNCliente.Insertar(Program.vidVehiculo, tbNombre.Text, tbApellido.Text, tbIdentificacion.Text, tbDireccion.Text, tbTelefono.Text, cbEstado.Text);
                }
                else
                {
                    mensaje = CNCliente.Actualizar(Program.vidVehiculo, tbNombre.Text, tbApellido.Text, tbIdentificacion.Text, tbDireccion.Text, tbTelefono.Text, cbEstado.Text);
                }

                MessageBox.Show(mensaje, "Mensage de P2Systems", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.nuevo = false;
                Program.modificar = false;
                HabilitaBotones();
                LimpiaObjetos();
            }//Fin del else para validar los datos 
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            HabilitaBotones();  //Habilita los objetos y botones correspondientes 
            LimpiaObjetos();   //Llama al método LimpiaObjetos
        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            if (!tbIdCliente.Equals(""))
            {
                Program.modificar = true;  //el formulaario se prepara para modificar datos 
                HabilitaBotones();
            }
            else
            {
                MessageBox.Show("Debe de buscar un Suplidor para poder Modificar sus datos!");
            }
        }

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




    }
}
