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
    public partial class FConsVentaDetalle : Form
    {
        public int vidVentaDetalle = 0, vtieneparametro = 0, indice = 1, vCantidad;
        public string valorparametro = "", mensaje = "";
        public static double vPrecio = 0, subTotalVenta = 0, itbisVenta = 0, totalVenta = 0, totalVendido = 0;
        CNVentaDetalle objVentaDetalle = new CNVentaDetalle();

        private void FConsVentaDetalle_Load(object sender, EventArgs e)
        {
            valorparametro = "";
            vtieneparametro = 0;
            MostrarDatos();
            tbBuscar.Focus();
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
            ReportVentaDetalle report = new ReportVentaDetalle();
            if (DGVDatos.CurrentRow != null) //Si el DataGridView no está vacío 
            {
                Program.vidVentaDetalle = Convert.ToInt32(DGVDatos.CurrentRow.Cells[0].Value);

                valorparametro = tbBuscar.Text.Trim();

                report.DataSource = objVentaDetalle.ObtenerVentaDetalle(valorparametro);
            }

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaGuardar = saveFileDialog1.FileName;
                report.RequestParameters = false;

                report.ExportToPdf(rutaGuardar + ".pdf");
            }
        }

        CNVentaDetalle objVehiculo = new CNVentaDetalle();

        public FConsVentaDetalle()
        {
            InitializeComponent();
        }

        private void MostrarDatos()
        {
            // Se toma el texto que se haya introducido en el textbox para usarlo como parámetro 
            string vparametro = "1";
            CNVentaDetalle cNVenta = new CNVentaDetalle();
            DataTable dt = new DataTable();
            dt = cNVenta.ObtenerVentaDetalle(vparametro);
            //Si el procedimiento almacenado devuelve algún valor se ajusta el ancho de las columnas del DataGridView 
            if (objVentaDetalle.ObtenerVentaDetalle(valorparametro) != null)
            {
                DGVDatos.DataSource = objVentaDetalle.ObtenerVentaDetalle(valorparametro);
                DGVDatos.Columns[0].Width = 80;    //IDVentaDetalle
                DGVDatos.Columns[1].Width = 200;   //NumeroRecibo
                DGVDatos.Columns[2].Width = 225;  //IdVehiculo
                DGVDatos.Columns[3].Width = 100;  //Precio
                DGVDatos.Columns[4].Width = 125;  //Cantidad   
                DGVDatos.Columns[5].Width = 125;  //Unidad
                totalVenta = calcularVenta(dt);
                totalVendido = totalVenta+totalVendido;
            }
            else           //Si el valor de vtieneparametro es 1 se ejecuta el método que filtra datos según el parámetro 
            {
                MessageBox.Show("No se retornó ningún valor!");
            }
            DGVDatos.Refresh();       //Se refresca el DataGridView 
            LCantVentaDetalle.Text = "Cantidad Vendido: " + totalVendido;  //Se muestra la cantidad de datos 
            if (DGVDatos.RowCount <= 0)                                           //Si no se obtienen datos de retorno 
            {
                MessageBox.Show("Ningún dato que mostrar!");   //Se muestra un mensaje de error 
            }
        }  //Fin del método mostrar


        private double calcularVenta(DataTable datos)
        {
            double totalVenta = 0;

            foreach (DataRow row in datos.Rows)
            {
                double precio = Convert.ToDouble(row["Precio"]);
                int cantidad = Convert.ToInt32(row["Cantidad"]);
                double subTotal = precio * cantidad;
                double itbis = subTotal * 0.18;
                totalVenta += subTotal - itbis;
            }

            return totalVenta;

        }



    }
}
