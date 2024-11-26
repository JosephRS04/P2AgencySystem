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
    public partial class FMantUsuario : Form
    {
        public string valorparametro = "", mensaje = "";

        public FMantUsuario()
        {
            InitializeComponent();
        }

        private void FMantUsuario_Load(object sender, EventArgs e)
        {
            string vparametro = "";
            Program.nuevo = false;
            Program.modificar = false;
            HabilitaBotones();


            CNEmpleado objEmpleado = new CNEmpleado();
            cbIdEmpleado.DataSource = objEmpleado.ObtenerEmpleado(vparametro);
            cbIdEmpleado.DisplayMember = "Nombre";
            cbIdEmpleado.ValueMember = "IdEmpleado";
            cbIdEmpleado.SelectedIndex = 0;
            string vEmpleado = cbIdEmpleado.Text;
            int VIdEmpleado = Convert.ToInt32(cbIdEmpleado.SelectedValue);


            CNRol objRol = new CNRol();
            cbIdRol.DataSource = objRol.ObtenerRol(vparametro);
            cbIdRol.DisplayMember = "FuncionRol";
            cbIdRol.ValueMember = "IdRol";
            cbIdRol.SelectedIndex = 0;
            string vRol = cbIdRol.Text;
            int vIdRol = Convert.ToInt32(cbIdRol.SelectedValue);
        }

        public void LimpiaObjetos()
        {
            tbIdUsuario.Clear();
            tbUsuario.Clear();
            tbClave.ResetText();
            cbIdEmpleado.SelectedItem = 0;
            cbIdRol.SelectedItem = 0;
            cbEstado.SelectedItem = 0;
        }// fin metodo limpiar objeto

        private void HabilitaControles(bool valor)
        {
            tbIdUsuario.ReadOnly = true;
            tbUsuario.Enabled = valor;
            tbClave.Enabled = valor;
            cbIdEmpleado.SelectedItem = 0;
            cbIdRol.SelectedItem = 0;
            cbEstado.SelectedItem = 0;

            if (Program.nuevo)
                cbEstado.SelectedIndex = 0;
        }// fin metodo habilitar controles

        private void bmenu_Click(object sender, EventArgs e)
        {
            FMenu menu = new FMenu();
            menu.closechildform(this);
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            LimpiaObjetos();
            Program.nuevo = true;
            Program.modificar = false;
            HabilitaBotones();
            tbIdUsuario.Focus();
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
            if (!tbIdUsuario.Equals(""))
            {
                Program.modificar = true;
                HabilitaBotones();
            }
            else
            {
                MessageBox.Show("Debe de buscar un usuario registrado para poder Modificar sus datos!");
            }
        }

        private void FMantUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }

        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            //FBuscarDepartamento fBuscarDepto = new FBuscarDepartamento(); 
            //fBuscarDepto.ShowDialog(); 
            if (Program.modificar)
            {
                RecuperaDatos();  //Llamo al método para recuperar el Depto seleccionado 
                bEditar_Click(sender, e);  //Llamo al método editar 
            }
            else
            {
                LimpiaObjetos(); //Llama al método LimpiaObjetos 
                bBuscar.Focus();
            }
        }

        public void RecuperaDatos()
        {
            string vparametro = Program.vidUsuario.ToString();
            CNUsuario cNUsuario = new CNUsuario();
            DataTable dt = new DataTable();
            dt = cNUsuario.ObtenerCliente(vparametro);
            foreach (DataRow row in dt.Rows)
            {
                tbIdUsuario.Text = row["IdUsuario"].ToString();
                tbUsuario.Text = row["Usuario"].ToString();
                tbClave.Text = row["Clave"].ToString();
                cbIdEmpleado.Text = row["IdEmpleado"].ToString();
                cbIdRol.Text = row["IdRol"].ToString();
                cbEstado.Text = row["Estado"].ToString();
            }




        }// fin metodo recuperar datos

        private void bGuardar_Click(object sender, EventArgs e)
        {
            if (tbUsuario.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar su usuario");
                tbUsuario.Focus();
            }
            else if (cbIdEmpleado.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar el Id de Empleado");
                cbIdEmpleado.Focus();
            }
            else if (tbClave.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar su clave ");
                tbClave.Focus();
            }
            else if (cbIdRol.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar su rol ");
                cbIdRol.Focus();
            }
            else if (cbEstado.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar el estado del Usuario");
                cbEstado.Focus();
            }
            else
            {
                if (Program.nuevo)
                {
                    mensaje = CNUsuario.Insertar(Program.vidUsuario ,tbUsuario.Text ,tbClave.Text, Convert.ToInt32(cbIdEmpleado.SelectedValue), Convert.ToInt32(cbIdRol.SelectedValue), cbEstado.Text);
                }
                else
                {
                    mensaje = CNUsuario.Actualizar(Program.vidUsuario ,tbUsuario.Text, tbClave.Text, Convert.ToInt32(cbIdEmpleado.SelectedValue), Convert.ToInt32(cbIdRol.SelectedValue), cbEstado.Text);
                }

                MessageBox.Show(mensaje, "Mensage de P2Systems", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.nuevo = false;
                Program.modificar = false;
                HabilitaBotones();
                LimpiaObjetos();

            }
        }

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




    }
}
