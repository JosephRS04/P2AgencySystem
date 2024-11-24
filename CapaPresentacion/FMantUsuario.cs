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
    public partial class FMantUsuario : Form
    {
        public FMantUsuario()
        {
            InitializeComponent();
        }

        private void FMantUsuario_Load(object sender, EventArgs e)
        {
            string vparametro = "";


            CNEmpleado objEmpleado = new CNEmpleado();
            cbEmpleado.DataSource = objEmpleado.ObtenerEmpleado(vparametro);
            cbEmpleado.DisplayMember = "Nombre";
            cbEmpleado.ValueMember = "IdEmpleado";
            cbEmpleado.SelectedIndex = 0;
            string vEmpleado = cbEmpleado.Text;
            int VIdEmpleado = Convert.ToInt32(cbEmpleado.SelectedValue);


            CNRol objRol = new CNRol();
            cbRol.DataSource = objRol.ObtenerRol(vparametro);
            cbRol.DisplayMember = "FuncionRol";
            cbRol.ValueMember = "IdRol";
            cbRol.SelectedIndex = 0;
            string vRol = cbRol.Text;
            int vIdRol = Convert.ToInt32(cbRol.SelectedValue);
        }
    }
}
