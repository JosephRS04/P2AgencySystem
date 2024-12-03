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
    public partial class FMantRol : Form
    {
        public string valorparametro = "", mensaje = "";

        public FMantRol()
        {
            InitializeComponent();
        }

        private void bmenu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public void LimpiaObjetos()
        {
            tbIdRol.Clear();
            tbfuncionrol.Clear();
            cbEstado.SelectedItem = 0;


        }// fin metodo limpiar objeto

        private void HabilitaControles(bool valor)
        {
            tbIdRol.ReadOnly = true;
            tbfuncionrol.Enabled = valor;
            cbEstado.Enabled = valor;

            if (Program.nuevo)
                cbEstado.SelectedIndex = 0;
        }// fin metodo habilitar controles

        private void bAgregar_Click(object sender, EventArgs e)
        {
            LimpiaObjetos();
            Program.nuevo = true;
            Program.modificar = false;
            HabilitaBotones();
            tbfuncionrol.Focus();

        }

        private void FMantRol_Load(object sender, EventArgs e)
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
            if (!tbIdRol.Equals(""))
            {
                Program.modificar = true;
                HabilitaBotones();
            }
            else
            {
                MessageBox.Show("Debe de buscar un ROl registrado para poder Modificar sus datos!");
            }

        }

        private void FMantRol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }

        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            FBuscarRol fBuscarrol = new FBuscarRol(); 
            fBuscarrol.ShowDialog(); 
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

        private void bGuardar_Click(object sender, EventArgs e)
        {
            if (tbfuncionrol.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar la funcion del Rol");
                tbfuncionrol.Focus();
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
                    mensaje = CNRol.Insertar(Program.vidRol, tbfuncionrol.Text, cbEstado.Text);
                }
                else
                {
                    mensaje = CNRol.Actualizar(Program.vidRol, tbfuncionrol.Text, cbEstado.Text);
                }

                MessageBox.Show(mensaje, "Mensage de P2Systems", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.nuevo = false;
                Program.modificar = false;
                HabilitaBotones();
                LimpiaObjetos();
            }//Fin del else para validar los datos 

        }

        public void RecuperaDatos()
        {
            string vparametro = Program.vidRol.ToString();
            CNRol cNROl = new CNRol();
            DataTable dt = new DataTable();
            dt = cNROl.ObtenerRol(vparametro);
            foreach (DataRow row in dt.Rows)
            {
                tbIdRol.Text = row["IdRol"].ToString();
                tbfuncionrol.Text = row["FuncionRol"].ToString();
                cbEstado.Text = row["Estado"].ToString();
            }

        }// fin metodo recuperar datos


        
    }
}
