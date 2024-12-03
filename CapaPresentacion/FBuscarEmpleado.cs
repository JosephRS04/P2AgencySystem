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
    public partial class FBuscarEmpleado : Form
    {
        public int indice = 0, vtieneparametro = 0;
        public string valorparametro = "";
        CNEmpleado cNEmpleado = new CNEmpleado();

        public FBuscarEmpleado()
        {
            InitializeComponent();
        }

        private void FBuscarEmpleado_Load(object sender, EventArgs e)
        {
            valorparametro = "";
            vtieneparametro = 0;
            Program.vidEmpleado = 0;  //variable global que tomará el valor seleccionado 
            MostrarDatos();               //Llamo al Método que llena el DataGrid 
            tbBuscar.Focus();
        }

        private void DGVDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
            {
                return;
            }
            bAceptar_Click(sender, e);
        }

        private void DGVDatos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (DGVDatos.CurrentRow != null)                  //Si el DataGridView no está vacío 
                indice = DGVDatos.CurrentRow.Index;     //El valor de índice será la fila actual
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            Program.modificar = false;    //variable global a toda la solución  
            Close();   //Se cierra el formulario
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (DGVDatos.CurrentRow != null) //Si el DataGridView no está vacío 
            {
                //variable global a toda la solución  se hace verdadera y se le asigna a la variable  global vidSuplidor 
                // el valor de la clave correspondiente 

                Program.modificar = true;
                Program.vidEmpleado = Convert.ToInt32(DGVDatos.CurrentRow.Cells[0].Value);
            }
            Close();
        }

        private void bPrimero_Click(object sender, EventArgs e)
        {
            if (DGVDatos.Rows.Count > 1)   //Si no estamos al inicio del DataGridView, vamos al inicio 
            {
                indice = 0;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
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

        private void bSiguiente_Click(object sender, EventArgs e)
        {
            if (indice < this.DGVDatos.RowCount - 1)    //Si no estamos al final del DataGridView, avanzamos 1 fila 
            {
                indice++;
                DGVDatos.CurrentCell =
                DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }

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

        private void bBuscar_Click(object sender, EventArgs e)
        {
            if (tbBuscar.Text != String.Empty) //Si se introdujo un dato en el textbox 
            {
                vtieneparametro = 1; //se indica que se trabajará con parámetros 
                                     //Se coloca el signo % para que el dato indicado se busque en cualquier parte del campo 
                valorparametro = "%" + tbBuscar.Text.Trim() + "%"; //valorparametro = tbBuscar.Text.Trim(); 
            }
            else //si el textbox está vacío 
            {
                vtieneparametro = 0; //se indica que no se trabajará con parámetros 
                valorparametro = ""; //Se vuelve vacío la variable del parámetro. 
            }
            MostrarDatos();
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGVDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //si se pulsa en el encabezado, RowIndex será menor que cero y no se hará nada 
            if (!(e.RowIndex > -1))
            {
                return;
            }
            bAceptar_Click(sender, e);
        }

        private void MostrarDatos()
        {
            valorparametro = tbBuscar.Text.Trim();
            if (cNEmpleado.ObtenerEmpleado(valorparametro) != null)
            {
                DGVDatos.DataSource = cNEmpleado.ObtenerEmpleado(valorparametro); //Se ejecuta el método para mostrar los datos
                DGVDatos.Columns[0].Width = 5;  //IDEmpleado 
                DGVDatos.Columns[1].Width = 10; //Nombre
                DGVDatos.Columns[2].Width = 10;  //Apellido
                DGVDatos.Columns[3].Width = 15;  //Telefono
                DGVDatos.Columns[4].Width = 15;  //FechaNacimiento
                DGVDatos.Columns[5].Width = 5;  //IdRol
                DGVDatos.Columns[6].Width = 5;  //Estado
                DGVDatos.Columns[7].Width = 15;  //Estado
            }
            else
                MessageBox.Show("No se retornó ningún valor!");

            DGVDatos.Refresh(); //Se refresca el DataGridView 
        } //Fin del método mostrar


    }
}
