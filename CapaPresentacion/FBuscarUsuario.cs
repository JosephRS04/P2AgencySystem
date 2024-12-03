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
    public partial class FBuscarUsuario : Form
    {
        public int indice = 0, vtieneparametro = 0;
        public string valorparametro = "";
        CNUsuario cNUsuario = new CNUsuario();

        public FBuscarUsuario()
        {
            InitializeComponent();
        }

        private void FBuscarUsuario_Load(object sender, EventArgs e)
        {
            valorparametro = "";
            vtieneparametro = 0;
            Program.vidUsuario = 0; // Variable global para el usuario seleccionado 
            MostrarDatos();         // Llenar el DataGridView con los datos iniciales 
            tbBuscar.Focus();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (DGVDatos.CurrentRow != null) // Si hay una fila seleccionada 
            {
                Program.modificar = true;
                Program.vidUsuario = Convert.ToInt32(DGVDatos.CurrentRow.Cells[0].Value);
            }
            Close();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            Program.modificar = false;
            Close();
        }

        private void bUltimo_Click(object sender, EventArgs e)
        {
            if (indice < this.DGVDatos.RowCount - 1)
            {
                indice = DGVDatos.Rows.Count - 1;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void bSiguiente_Click(object sender, EventArgs e)
        {
            if (indice < this.DGVDatos.RowCount - 1)    //Si no estamos al final del DataGridView, avanzamos 1 fila 
            {
                indice++;
                DGVDatos.CurrentCell =
                DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void bAnterior_Click(object sender, EventArgs e)
        {
            if (indice > 0)       //Si no estamos al inicio del DataGridView, retrocedemos 1 fila 
            {
                indice = indice - 1;
                DGVDatos.CurrentCell =
                DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void bPrimero_Click(object sender, EventArgs e)
        {
            if (DGVDatos.Rows.Count > 1)   //Si no estamos al inicio del DataGridView, vamos al inicio 
            {
                indice = 0;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void DGVDatos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (DGVDatos.CurrentRow != null)
                indice = DGVDatos.CurrentRow.Index;
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbBuscar.Text))
            {
                vtieneparametro = 1;
                valorparametro = "%" + tbBuscar.Text.Trim() + "%";
            }
            else
            {
                vtieneparametro = 0;
                valorparametro = "";
            }
            MostrarDatos();
        }


        private void DGVDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                bAceptar_Click(sender, e);
            }
        }

        private void MostrarDatos()
        {
            valorparametro = tbBuscar.Text.Trim();
            if (cNUsuario.ObtenerUsuario(valorparametro) != null)
            {
                DGVDatos.DataSource = cNUsuario.ObtenerUsuario(valorparametro);
                DGVDatos.Columns[0].Width = 80;  // IdUsuario 
                DGVDatos.Columns[1].Width = 150; // Usuario 
                DGVDatos.Columns[2].Width = 150; // Clave 
                DGVDatos.Columns[3].Width = 100; // IdEmpleado 
                DGVDatos.Columns[4].Width = 100; // IdRol
                DGVDatos.Columns[5].Width = 80;  // Estado
            }
            else
                MessageBox.Show("No se encontraron resultados.");

            DGVDatos.Refresh();
        }


    }
}
