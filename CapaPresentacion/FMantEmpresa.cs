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
    public partial class FMantEmpresa : Form
    {
        public string valorparametro = "", mensaje = "";

        public FMantEmpresa()
        {
            InitializeComponent();
        }

        public void LimpiaObjetos()
        {
            tbIdEmpresa.Clear();
            tbNombreEmp.Clear();
            tbRNC.Clear();
            tbDireccion.Clear();
            tbTelefono.Clear();
            tbSlogan.Clear();
            tbCorreo.Clear();
            tbGerente.Clear();
        }// fin metodo limpiar objeto

        private void HabilitaControles(bool valor)
        {
            tbNombreEmp.ReadOnly = valor;
            tbRNC.ReadOnly = valor;
            tbDireccion.ReadOnly = valor;
            tbTelefono.ReadOnly = valor;
            tbSlogan.ReadOnly = valor;
            tbCorreo.ReadOnly = valor;
            tbGerente.ReadOnly = valor;
        }// fin metodo habilitar controles

        private void bAgregar_Click(object sender, EventArgs e)
        {        
            HabilitaControles(false);
            bAgregar.Enabled = false;
            bGuardar.Enabled = true;
            bBorrar.Enabled = true;

            if (!tbIdEmpresa.Text.Equals(""))
            {
                Program.modificar = true;  //el formulaario se prepara para modificar datos 
            }
            else
            {
                Program.nuevo = true;
                tbNombreEmp.Focus();   //Coloca el cursor en el TextBox indicado
            }
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            if (tbNombreEmp.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar el Nombre de la empresa");
                tbNombreEmp.Focus();
            }
            else if (tbRNC.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar el RNC de la empresa");
                tbRNC.Focus();
            }
            else if (tbDireccion.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar la dirección de la empresa");
                tbDireccion.Focus();
            }
            else if (tbTelefono.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar el telefono de la empresa");
                tbTelefono.Focus();
            }
            else if (tbSlogan.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar el slogan de la empresa");
                tbSlogan.Focus();
            }
            else if (tbCorreo.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar el correo de la empresa");
                tbCorreo.Focus();
            }
            else if (tbGerente.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar el gerente de la empresa");
                tbGerente.Focus();
            }
            else
            {
                if (Program.nuevo)
                {
                    mensaje = CNEmpresa.Insertar(Program.vidEmpresa, tbNombreEmp.Text, tbRNC.Text, tbDireccion.Text, tbTelefono.Text, tbSlogan.Text, tbCorreo.Text, tbGerente.Text);
                }
                else
                {
                    mensaje = CNEmpresa.Actualizar(Program.vidEmpresa, tbNombreEmp.Text, tbRNC.Text, tbDireccion.Text, tbTelefono.Text, tbSlogan.Text, tbCorreo.Text, tbGerente.Text);
                }

                MessageBox.Show(mensaje, "Mensage de P2Systems", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.nuevo = false;
                Program.modificar = false;
                HabilitaControles(true);
                bAgregar.Enabled = true;
                bGuardar.Enabled = false;
                bBorrar.Enabled = false;
            }//Fin del else para validar los datos 
        }

        private void FMantEmpresa_Load(object sender, EventArgs e)
        {
            Program.nuevo = false;           //Valores de las variables globales nuevo y modificar 
            Program.modificar = false;

            HabilitaControles(true);
            RecuperaDatos();
            
            bGuardar.Enabled = false;
            bBorrar.Enabled = false;

        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            HabilitaBotones();  //Habilita los objetos y botones correspondientes 
            LimpiaObjetos();   //Llama al método LimpiaObjetos
        }

        private void FMantEmpresa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void HabilitaBotones()
        {
            if (Program.nuevo || Program.modificar)
            {
                HabilitaControles(true);
                bAgregar.Enabled = false;
                bGuardar.Enabled = true;
                bBorrar.Enabled = true;
            }
            else
            {
                HabilitaControles(false);
                bAgregar.Enabled = true;
                bGuardar.Enabled = true;
                bBorrar.Enabled = true;
            }
        }

        private void bmenu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public void RecuperaDatos()
        {
            Program.vidEmpresa = 4;
            string vparametro = Program.vidEmpresa.ToString();
            CNEmpresa cNEmpresa = new CNEmpresa();
            DataTable dt = cNEmpresa.ObtenerEmpresa(vparametro);
            if (dt.Rows.Count > 0) // Verifica si hay al menos una fila en la tabla
            {
                DataRow row = dt.Rows[0];
                tbIdEmpresa.Text = row["IdEmpresa"].ToString();
                tbNombreEmp.Text = row["NombreEmp"].ToString();
                tbRNC.Text = row["RNC"].ToString();
                tbDireccion.Text = row["Direccion"].ToString();
                tbTelefono.Text = row["Telefono"].ToString();
                tbSlogan.Text = row["Slogan"].ToString();
                tbCorreo.Text = row["Correo"].ToString();
                tbGerente.Text = row["Gerente"].ToString();
            }
        } //Fin del metodo RecuperarDatos 



    }// fin clase
}
