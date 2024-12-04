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
    public partial class FConsEmpleado : Form
    {
        public int indice = 0, vtieneparametro = 0;
        public string valorparametro = "";
        CNEmpleado cNEmpleado = new CNEmpleado();

        private void FConsEmpleado_Load(object sender, EventArgs e)
        {
            valorparametro = "";
            vtieneparametro = 0;
            MostrarDatos();
            tbBuscar.Focus();
        }

        public FConsEmpleado()
        {
            InitializeComponent();
        }

        private void DGVDatos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (DGVDatos.CurrentRow != null)                  //Si el DataGridView no está vacío 
                indice = DGVDatos.CurrentRow.Index;
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            if (tbBuscar.Text != String.Empty)    //Si se introdujo un dato en el textbox 
            {
                vtieneparametro = 1;            //se indica que se trabajará con parámetros 
                                                //Se coloca el signo % para que el dato indicado se busque en cualquier parte del campo 
                valorparametro = "%" + tbBuscar.Text.Trim() + "%";
            }
            else    //si el textbox está vacío  
            {
                vtieneparametro = 0;   //se indica que no se trabajará con parámetros 
                valorparametro = "";   //Se vuelve vacío la variable del parámetro. 
            }
            MostrarDatos();    //Se llama al método MostrarDatos 
            tbBuscar.Focus();   //Se le pasa el cursos al textbox 
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

        private void bImprimir_Click(object sender, EventArgs e)
        {
            ReportEmpleados report = new ReportEmpleados();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaGuardar = saveFileDialog1.FileName;


                report.ExportToPdf(rutaGuardar + ".pdf");
                rutaGuardar = "";
            }
        }

        private void MostrarDatos()
        {          
            valorparametro = tbBuscar.Text.Trim();
            if (cNEmpleado.ObtenerEmpleado(valorparametro) != null)
            {
                DGVDatos.DataSource = cNEmpleado.ObtenerEmpleado(valorparametro);
                DGVDatos.Columns[0].Width = 80;    //IDEmpleado 
                DGVDatos.Columns[1].Width = 200;   //Nombre
                DGVDatos.Columns[2].Width = 225;  //Apellido 
                DGVDatos.Columns[3].Width = 100;  //Telefono 
                DGVDatos.Columns[4].Width = 125;  //FechaNacimiento
                DGVDatos.Columns[5].Width = 125;  //IdRol
                DGVDatos.Columns[6].Width = 150;  //FuncionRol
                DGVDatos.Columns[7].Width = 100;  //Estado  
            }
            else           //Si el valor de vtieneparametro es 1 se ejecuta el método que filtra datos según el parámetro 
            {
                MessageBox.Show("No se retornó ningún valor!");
            }
            DGVDatos.Refresh();       //Se refresca el DataGridView 
            LCantEmpleado.Text = "Cantidad de empleados: " + Convert.ToString(DGVDatos.RowCount - 1);  //Se muestra la cantidad de datos 
            if (DGVDatos.RowCount <= 0)                                           //Si no se obtienen datos de retorno 
            {
                MessageBox.Show("Ningún dato que mostrar!");   //Se muestra un mensaje de error 
            }
        }  //Fin del método mostrar

    }
}
