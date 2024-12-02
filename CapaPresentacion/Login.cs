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
    public partial class Login : Form
    {
        string vUsuario = "", vClave = "";
        public static string miconexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\JRProgramaciones\P2AgencySystem\CapaDatos\DBAgencySystem.mdf;Integrated Security=True";
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUsuario.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un usuario");
                LimpiarCampos();
            }
            else if (tbClave.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar una clave");
                LimpiarCampos();
            }
            else
            {
                vUsuario = tbUsuario.Text;
                vClave = tbClave.Text;
                Dictionary<string, string> credenciales = new Dictionary<string, string>();
                using (SqlConnection miConexion = new SqlConnection(miconexion))
                {
                    SqlCommand miInstruccion = new SqlCommand("SELECT Usuario, Clave FROM Usuario", miConexion);
                    miConexion.Open();

                    using (SqlDataReader miDataReader = miInstruccion.ExecuteReader())
                    {
                        while (miDataReader.Read())
                        {
                            // Agregar los valores existentes al HashSet
                            credenciales.Add( Convert.ToString(miDataReader["Usuario"]), Convert.ToString(miDataReader["Clave"]) );
                        }
                    }
                }

                if (credenciales.ContainsKey(vUsuario) && credenciales[vUsuario] == vClave)
                {
                    FMenu menu = new FMenu();
                    menu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos, vuelva a intentarlo");
                    LimpiarCampos();
                }


            }

        }// fin metodo

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LimpiarCampos()
        {
            tbUsuario.Text = "";
            tbClave.Text = "";
            tbUsuario.Focus();
        }


    }
}
