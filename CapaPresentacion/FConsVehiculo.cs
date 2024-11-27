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
    public partial class FConsVehiculo : Form
    {
        public int vidVehiculo = 0, vtieneparametro = 0, indice = 1;
        public string valorparametro = "", mensaje = "";
        CNVehiculo objVehiculo = new CNVehiculo();

        private void DGVDatos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (DGVDatos.CurrentRow != null)                  //Si el DataGridView no está vacío 
                indice = DGVDatos.CurrentRow.Index;
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Close();  
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

        public FConsVehiculo()
        {
            InitializeComponent();
        }

        private void FConsVehiculo_Load(object sender, EventArgs e)
        {
            valorparametro = "";
            vtieneparametro = 0;
            MostrarDatos();
            tbBuscar.Focus();
        }

        private void MostrarDatos()
        {
            // Se toma el texto que se haya introducido en el textbox para usarlo como parámetro 
            valorparametro = tbBuscar.Text.Trim();
            //Si el procedimiento almacenado devuelve algún valor se ajusta el ancho de las columnas del DataGridView 
            if (objVehiculo.ObtenerVehiculo(valorparametro) != null)
            {
                DGVDatos.DataSource = objVehiculo.ObtenerVehiculo(valorparametro); //Se ejecuta el método para mostrar los datos
                DGVDatos.Columns[0].Width = 80;    //IDVehiculo 
                DGVDatos.Columns[1].Width = 100;   //VIN
                DGVDatos.Columns[2].Width = 225;  //Marca
                DGVDatos.Columns[3].Width = 100;  //Modelo
                DGVDatos.Columns[4].Width = 125;  //Ano
                DGVDatos.Columns[5].Width = 125;  //Tipo
                DGVDatos.Columns[6].Width = 150;  //Kilometraje
                DGVDatos.Columns[7].Width = 100;  //FechaIngreso
                DGVDatos.Columns[8].Width = 100;  //Informaciones
                DGVDatos.Columns[9].Width = 100;  //Existencia
                DGVDatos.Columns[10].Width = 100;  //Precio
                DGVDatos.Columns[11].Width = 90;   //Estado 
            }
            else           //Si el valor de vtieneparametro es 1 se ejecuta el método que filtra datos según el parámetro 
            {
                MessageBox.Show("No se retornó ningún valor!");
            }
            DGVDatos.Refresh();       //Se refresca el DataGridView 
            LCantVehiculo.Text = "Cantidad de vehiculos: " + Convert.ToString(DGVDatos.RowCount);  //Se muestra la cantidad de datos 
            if (DGVDatos.RowCount <= 0)                                           //Si no se obtienen datos de retorno 
            {
                MessageBox.Show("Ningún dato que mostrar!");   //Se muestra un mensaje de error 
            }
        }  //Fin del método mostrar

    }
}
