using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    
    public partial class FMenu : Form
    {
        public static FMenu Instance { get; private set; }
        private Form currentChildForm;
        Form formVehiculo;
        Form formCliente;
        Form formEmpleado;
        Form formRol;
        Form formVenta;

        public FMenu()
        {
            InitializeComponent();
            Instance = this;
        }

        public void closechildform(Form childform)
        {
            childform.Close();
            childform = null;
            this.Close();
        }

        public void openChildForm(Form childForm)
        {
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            panelDesktop.Visible = true;
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void porModeloToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nombreDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FMenu_Load(object sender, EventArgs e)
        {
            
            panelDesktop.Visible = false;
            //this.BackgroundImage = 
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusStrip1.Items[2].Text = "Fecha/Hora: " + DateTime.Now.ToString();
        }

        private void consultasYReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esto le hará salir de la aplicación ¿Está seguro que desea salir?", "Mensaje de P2Systems",MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void editorDeTextosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword.exe");
        }

        private void navegadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("msedge.exe");
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formCliente != null)
            {
                formCliente.BringToFront();
                formCliente.Show();
            }
            else
            {
                formCliente = new FMantCliente();
                openChildForm(formCliente);
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formVehiculo != null)
            {
                formVehiculo.BringToFront();
                formVehiculo.Show();
            }
            else
            {
                formVehiculo = new FMantVehiculo();
                openChildForm(formVehiculo);
            }
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formEmpleado != null)
            {
                formEmpleado.BringToFront();
                formEmpleado.Show();
            }
            else
            {
                formEmpleado = new FMantEmpleado();
                openChildForm(formEmpleado);
            }
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formRol != null)
            {
                formRol.BringToFront();
                formRol.Show();
            }
            else
            {
                formRol = new FMantRol();
                openChildForm(formRol);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void usariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cuentasDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FMantUsuario());
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registrarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FMantEmpresa());
        }

        private void datosGeneralesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openChildForm(new FConsCliente());
        }

        private void datosGeneralesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FConsVehiculo()); 
        }

        private void salidaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formVenta != null)
            {
                formVenta.BringToFront();
                formVenta.Show();
            }
            else
            {
                formVenta = new FProcVenta();
                openChildForm(formVenta);
            }
        }

        private void empleadoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
