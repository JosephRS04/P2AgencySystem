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
    public partial class FBuscarCliente : Form
    {
        public int indice = 0, vtieneparametro = 0;
        public string valorparametro = "";
        CNCliente cNCliente = new CNCliente();


        public FBuscarCliente()
        {
            InitializeComponent();
        }

        private void FBuscarCliente_Load_1(object sender, EventArgs e)
        {
            valorparametro = "";
            vtieneparametro = 0;
            Program.vidCliente = 0;  //variable global que tomará el valor seleccionado 
            MostrarDatos();               //Llamo al Método que llena el DataGrid 
            tbBuscar.Focus();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (DGVDatos.CurrentRow != null) //Si el DataGridView no está vacío 
            {
                Program.modificar = true;
                Program.vidCliente = Convert.ToInt32(DGVDatos.CurrentRow.Cells[0].Value);
            }
            Close();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            Program.modificar = false;    //variable global a toda la solución  
            Close();   //Se cierra el formulario
        }

        private void bUltimo_Click(object sender, EventArgs e)
        {
            if (indice < this.DGVDatos.RowCount - 1)   //Si no estamos al final del DataGridView 
            {
                indice = DGVDatos.Rows.Count - 1;         //vamos a la última fila del DataGridView 
                DGVDatos.CurrentCell =
                DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
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
            if (DGVDatos.CurrentRow != null)                  //Si el DataGridView no está vacío 
                indice = DGVDatos.CurrentRow.Index;    //El valor de índice será la fila actual
        }

        private void tbBuscar_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            if (tbBuscar.Text != String.Empty) //Si se introdujo un dato en el textbox 
            {
                vtieneparametro = 1; //se indica que se trabajará con parámetros 
                valorparametro = "%" + tbBuscar.Text.Trim() + "%"; //Se coloca el signo % para que el dato indicado se busque en cualquier parte del campo valorparametro = tbBuscar.Text.Trim(); 
            }
            else //si el textbox está vacío 
            {
                vtieneparametro = 0; //se indica que no se trabajará con parámetros 
                valorparametro = ""; //Se vuelve vacío la variable del parámetro. 
            }
            MostrarDatos(); //Se llama al método MostrarDatos
        }

        private void tbBuscar_Enter(object sender, EventArgs e)
        {

        }

        private void DGVDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
            {
                return;
            }
            bAceptar_Click(sender, e);
        }

        private void MostrarDatos()
        {
            valorparametro = tbBuscar.Text.Trim();
            if (cNCliente.ObtenerCliente(valorparametro) != null)
            {
                DGVDatos.DataSource = cNCliente.ObtenerCliente(valorparametro);
                DGVDatos.Columns[0].Width = 80;   //IDCliente 
                DGVDatos.Columns[1].Width = 200;  //Nombre
                DGVDatos.Columns[2].Width = 225;  //Apellido
                DGVDatos.Columns[3].Width = 100;  //Identificación
                DGVDatos.Columns[4].Width = 125;  //Direccion
                DGVDatos.Columns[5].Width = 125;  //Telefono
                DGVDatos.Columns[6].Width = 150;  //Estado
            }
            else
                MessageBox.Show("No se retornó ningún valor!");

            DGVDatos.Refresh(); //Se refresca el DataGridView 
        }//Fin del método mostrar


    }
}
