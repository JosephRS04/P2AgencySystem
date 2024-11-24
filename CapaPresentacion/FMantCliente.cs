using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class FMantCliente : Form
    {
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

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            FBuscarCliente fBuscarSuplidor = new FBuscarCliente();
            fBuscarSuplidor.ShowDialog();
            if (Program.modificar)      //Si se está en modo de edición 
            {
                RecuperaDatos();  //Llamo al método para recuperar el registro seleccionado 
                //bEditar_Click(sender, e);     //Llamo el método del botón Editar 
            }
            else          //Si no estamos en modo de edición no permite la acción. 
            {
                //LimpiaObjetos(); //Llama al método LimpiaObjetos 
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




    }
}
