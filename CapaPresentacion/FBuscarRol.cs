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
    public partial class FBuscarRol : Form
    {
        public int indice = 0, vtieneparametro = 0;
        public string valorparametro = "";
        CNRol cNRol = new CNRol();

        public FBuscarRol()
        {
            InitializeComponent();
        }

        private void FBuscarRol_Load(object sender, EventArgs e)
        {
            valorparametro = "";
            vtieneparametro = 0;
            Program.vidRol = 0;  // Variable global para el rol seleccionado 
            MostrarDatos();      // Llenar el DataGrid con los datos iniciales 
            tbBuscar.Focus();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (DGVDatos.CurrentRow != null) // Si hay una fila seleccionada 
            {
                Program.modificar = true;
                Program.vidRol = Convert.ToInt32(DGVDatos.CurrentRow.Cells[0].Value);
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
            if (indice < this.DGVDatos.RowCount - 1)
            {
                indice++;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void bAnterior_Click(object sender, EventArgs e)
        {
            if (indice > 0)
            {
                indice--;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void bPrimero_Click(object sender, EventArgs e)
        {
            if (DGVDatos.Rows.Count > 1)
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


        private void MostrarDatos()
        {
            valorparametro = tbBuscar.Text.Trim();
            var datos = cNRol.ObtenerRol(valorparametro);
            if (datos != null)
            {
                DGVDatos.DataSource = datos;

               DGVDatos.Columns[0].Width = 80;  // IdRol 
                DGVDatos.Columns[1].Width = 200; // FuncionRol 
                DGVDatos.Columns[2].Width = 100; // Estado 
            }
            else
            {
                MessageBox.Show("No se encontraron resultados.");
            }
            DGVDatos.Refresh();
        }

        private void DGVDatos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                bAceptar_Click(sender, e);
            }
        }


    }
}
