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
    public partial class FMantEmpleado : Form
    {
        public FMantEmpleado()
        {
            InitializeComponent();
        }

        private void FMantEmpleado_Load(object sender, EventArgs e)
        {
            string vparametro = "";
            CNRol objRol = new CNRol();
            cbRol.DataSource = objRol.ObtenerRol(vparametro);
            cbRol.DisplayMember = "FuncionRol";
            cbRol.ValueMember = "IdRol";
            cbRol.SelectedIndex = 0;
            string vRol = cbRol.Text;
            int vIdRol = Convert.ToInt32(cbRol.SelectedValue);
        }

        private void cbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
