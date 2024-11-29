
namespace CapaPresentacion
{
    partial class FProcVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FProcVenta));
            this.bBuscarVehiculo = new System.Windows.Forms.Button();
            this.tbNCF = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbCondicion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lbTotal = new System.Windows.Forms.ToolStripLabel();
            this.lbItebis = new System.Windows.Forms.ToolStripLabel();
            this.lbSubTotal = new System.Windows.Forms.ToolStripLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bmenu = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIdEmpleado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbIdCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PTitulo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbIdVehiculo = new System.Windows.Forms.TextBox();
            this.bBuscarCliente = new System.Windows.Forms.Button();
            this.bBuscarEmpleado = new System.Windows.Forms.Button();
            this.cbTipofactura = new System.Windows.Forms.ComboBox();
            this.tbUnidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.tbEmpleado = new System.Windows.Forms.TextBox();
            this.tbVehiculo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tbExistencia = new System.Windows.Forms.TextBox();
            this.labelCondicion = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.PTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // bBuscarVehiculo
            // 
            this.bBuscarVehiculo.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscarVehiculo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bBuscarVehiculo.Image = ((System.Drawing.Image)(resources.GetObject("bBuscarVehiculo.Image")));
            this.bBuscarVehiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bBuscarVehiculo.Location = new System.Drawing.Point(657, 292);
            this.bBuscarVehiculo.Name = "bBuscarVehiculo";
            this.bBuscarVehiculo.Size = new System.Drawing.Size(298, 85);
            this.bBuscarVehiculo.TabIndex = 55;
            this.bBuscarVehiculo.Text = "Buscar Vehiculo ";
            this.bBuscarVehiculo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bBuscarVehiculo.UseVisualStyleBackColor = true;
            this.bBuscarVehiculo.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // tbNCF
            // 
            this.tbNCF.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNCF.Location = new System.Drawing.Point(25, 296);
            this.tbNCF.Name = "tbNCF";
            this.tbNCF.Size = new System.Drawing.Size(531, 44);
            this.tbNCF.TabIndex = 82;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 36);
            this.label12.TabIndex = 81;
            this.label12.Text = "NCF";
            // 
            // tbPrecio
            // 
            this.tbPrecio.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecio.Location = new System.Drawing.Point(27, 758);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.ReadOnly = true;
            this.tbPrecio.Size = new System.Drawing.Size(531, 44);
            this.tbPrecio.TabIndex = 79;
            this.tbPrecio.TextChanged += new System.EventHandler(this.tbPrecio_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 728);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 36);
            this.label11.TabIndex = 78;
            this.label11.Text = "Precio";
            // 
            // tbCondicion
            // 
            this.tbCondicion.Enabled = false;
            this.tbCondicion.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCondicion.Location = new System.Drawing.Point(27, 450);
            this.tbCondicion.Name = "tbCondicion";
            this.tbCondicion.Size = new System.Drawing.Size(176, 44);
            this.tbCondicion.TabIndex = 77;
            this.tbCondicion.Text = "0";
            this.tbCondicion.TextChanged += new System.EventHandler(this.tbCondicion_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 419);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 36);
            this.label10.TabIndex = 76;
            this.label10.Text = "Condición";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 805);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 36);
            this.label8.TabIndex = 73;
            this.label8.Text = "Estado";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripLabel1,
            this.lbTotal,
            this.lbItebis,
            this.lbSubTotal});
            this.toolStrip1.Location = new System.Drawing.Point(1196, 69);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(690, 837);
            this.toolStrip1.TabIndex = 72;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(685, 36);
            this.toolStripLabel2.Text = "Anotación";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(685, 36);
            this.toolStripLabel1.Text = "Todos los campos deben estar llenos antes de guardar.";
            // 
            // lbTotal
            // 
            this.lbTotal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbTotal.Font = new System.Drawing.Font("Times New Roman", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(685, 79);
            this.lbTotal.Text = "Total: ";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbItebis
            // 
            this.lbItebis.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbItebis.Font = new System.Drawing.Font("Times New Roman", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItebis.Name = "lbItebis";
            this.lbItebis.Size = new System.Drawing.Size(685, 79);
            this.lbItebis.Text = "18% Itbis: ";
            this.lbItebis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSubTotal
            // 
            this.lbSubTotal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbSubTotal.Font = new System.Drawing.Font("Times New Roman", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubTotal.Name = "lbSubTotal";
            this.lbSubTotal.Size = new System.Drawing.Size(685, 79);
            this.lbSubTotal.Text = "Sub-Total: ";
            this.lbSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.bmenu);
            this.panel3.Controls.Add(this.bCancelar);
            this.panel3.Controls.Add(this.bGuardar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.ForeColor = System.Drawing.Color.Coral;
            this.panel3.Location = new System.Drawing.Point(0, 906);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1886, 83);
            this.panel3.TabIndex = 69;
            // 
            // bmenu
            // 
            this.bmenu.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bmenu.Image = ((System.Drawing.Image)(resources.GetObject("bmenu.Image")));
            this.bmenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bmenu.Location = new System.Drawing.Point(1516, 3);
            this.bmenu.Name = "bmenu";
            this.bmenu.Size = new System.Drawing.Size(170, 73);
            this.bmenu.TabIndex = 4;
            this.bmenu.Text = "Salir";
            this.bmenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bmenu.UseVisualStyleBackColor = true;
            this.bmenu.Click += new System.EventHandler(this.bmenu_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bCancelar.Image = ((System.Drawing.Image)(resources.GetObject("bCancelar.Image")));
            this.bCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCancelar.Location = new System.Drawing.Point(179, 3);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(185, 73);
            this.bCancelar.TabIndex = 3;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bGuardar.Image = ((System.Drawing.Image)(resources.GetObject("bGuardar.Image")));
            this.bGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bGuardar.Location = new System.Drawing.Point(3, 3);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(170, 73);
            this.bGuardar.TabIndex = 1;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // tbCantidad
            // 
            this.tbCantidad.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantidad.Location = new System.Drawing.Point(27, 604);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(531, 44);
            this.tbCantidad.TabIndex = 68;
            this.tbCantidad.TextChanged += new System.EventHandler(this.tbCantidad_TextChanged);
            this.tbCantidad.Leave += new System.EventHandler(this.tbCantidad_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 574);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 36);
            this.label6.TabIndex = 67;
            this.label6.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 36);
            this.label5.TabIndex = 65;
            this.label5.Text = "Tipo de factura";
            // 
            // tbIdEmpleado
            // 
            this.tbIdEmpleado.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdEmpleado.Location = new System.Drawing.Point(764, 696);
            this.tbIdEmpleado.Name = "tbIdEmpleado";
            this.tbIdEmpleado.Size = new System.Drawing.Size(422, 44);
            this.tbIdEmpleado.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(651, 657);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(304, 36);
            this.label4.TabIndex = 63;
            this.label4.Text = "Empleado encargado";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.ForeColor = System.Drawing.Color.Coral;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2570, 5);
            this.panel2.TabIndex = 60;
            // 
            // tbIdCliente
            // 
            this.tbIdCliente.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdCliente.Location = new System.Drawing.Point(764, 430);
            this.tbIdCliente.Name = "tbIdCliente";
            this.tbIdCliente.Size = new System.Drawing.Size(424, 44);
            this.tbIdCliente.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(652, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 36);
            this.label2.TabIndex = 57;
            this.label2.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 60);
            this.label1.TabIndex = 56;
            this.label1.Text = "Registrar Venta";
            // 
            // PTitulo
            // 
            this.PTitulo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PTitulo.Controls.Add(this.panel1);
            this.PTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PTitulo.Location = new System.Drawing.Point(0, 0);
            this.PTitulo.Name = "PTitulo";
            this.PTitulo.Size = new System.Drawing.Size(1886, 69);
            this.PTitulo.TabIndex = 59;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Coral;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1886, 69);
            this.panel1.TabIndex = 6;
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbEstado.Location = new System.Drawing.Point(26, 835);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbEstado.Size = new System.Drawing.Size(531, 44);
            this.cbEstado.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(652, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 36);
            this.label7.TabIndex = 71;
            this.label7.Text = "Vehiculo";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tbIdVehiculo
            // 
            this.tbIdVehiculo.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdVehiculo.Location = new System.Drawing.Point(765, 145);
            this.tbIdVehiculo.Name = "tbIdVehiculo";
            this.tbIdVehiculo.Size = new System.Drawing.Size(425, 44);
            this.tbIdVehiculo.TabIndex = 83;
            this.tbIdVehiculo.TextChanged += new System.EventHandler(this.tbVehiculo_TextChanged);
            // 
            // bBuscarCliente
            // 
            this.bBuscarCliente.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscarCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("bBuscarCliente.Image")));
            this.bBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bBuscarCliente.Location = new System.Drawing.Point(658, 530);
            this.bBuscarCliente.Name = "bBuscarCliente";
            this.bBuscarCliente.Size = new System.Drawing.Size(297, 85);
            this.bBuscarCliente.TabIndex = 84;
            this.bBuscarCliente.Text = "Buscar Cliente ";
            this.bBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bBuscarCliente.UseVisualStyleBackColor = true;
            this.bBuscarCliente.Click += new System.EventHandler(this.bBuscarCliente_Click);
            // 
            // bBuscarEmpleado
            // 
            this.bBuscarEmpleado.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscarEmpleado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bBuscarEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("bBuscarEmpleado.Image")));
            this.bBuscarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bBuscarEmpleado.Location = new System.Drawing.Point(658, 794);
            this.bBuscarEmpleado.Name = "bBuscarEmpleado";
            this.bBuscarEmpleado.Size = new System.Drawing.Size(297, 85);
            this.bBuscarEmpleado.TabIndex = 86;
            this.bBuscarEmpleado.Text = "Buscar Empleado";
            this.bBuscarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bBuscarEmpleado.UseVisualStyleBackColor = true;
            // 
            // cbTipofactura
            // 
            this.cbTipofactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipofactura.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipofactura.FormattingEnabled = true;
            this.cbTipofactura.Items.AddRange(new object[] {
            "Credito",
            "Contado"});
            this.cbTipofactura.Location = new System.Drawing.Point(28, 373);
            this.cbTipofactura.Name = "cbTipofactura";
            this.cbTipofactura.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbTipofactura.Size = new System.Drawing.Size(531, 44);
            this.cbTipofactura.TabIndex = 88;
            this.cbTipofactura.SelectedIndexChanged += new System.EventHandler(this.cbTipofactura_SelectedIndexChanged);
            // 
            // tbUnidad
            // 
            this.tbUnidad.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUnidad.Location = new System.Drawing.Point(27, 681);
            this.tbUnidad.Name = "tbUnidad";
            this.tbUnidad.Size = new System.Drawing.Size(531, 44);
            this.tbUnidad.TabIndex = 90;
            this.tbUnidad.TextChanged += new System.EventHandler(this.tbUnidad_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 651);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 36);
            this.label3.TabIndex = 89;
            this.label3.Text = "Unidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 497);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 36);
            this.label9.TabIndex = 91;
            this.label9.Text = "Fecha";
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFecha.Location = new System.Drawing.Point(28, 527);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(528, 44);
            this.dateTimePickerFecha.TabIndex = 92;
            // 
            // tbCliente
            // 
            this.tbCliente.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCliente.Location = new System.Drawing.Point(764, 480);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(423, 44);
            this.tbCliente.TabIndex = 93;
            // 
            // tbEmpleado
            // 
            this.tbEmpleado.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmpleado.Location = new System.Drawing.Point(764, 744);
            this.tbEmpleado.Name = "tbEmpleado";
            this.tbEmpleado.Size = new System.Drawing.Size(424, 44);
            this.tbEmpleado.TabIndex = 94;
            // 
            // tbVehiculo
            // 
            this.tbVehiculo.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVehiculo.Location = new System.Drawing.Point(765, 195);
            this.tbVehiculo.Name = "tbVehiculo";
            this.tbVehiculo.Size = new System.Drawing.Size(425, 44);
            this.tbVehiculo.TabIndex = 95;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(651, 488);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 36);
            this.label13.TabIndex = 96;
            this.label13.Text = "Nombre";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(652, 438);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 36);
            this.label14.TabIndex = 97;
            this.label14.Text = "ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(652, 703);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 36);
            this.label15.TabIndex = 99;
            this.label15.Text = "ID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(651, 752);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 36);
            this.label16.TabIndex = 98;
            this.label16.Text = "Nombre";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(653, 153);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 36);
            this.label17.TabIndex = 101;
            this.label17.Text = "ID";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(652, 203);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(114, 36);
            this.label18.TabIndex = 100;
            this.label18.Text = "Modelo";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(652, 253);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 36);
            this.label19.TabIndex = 103;
            this.label19.Text = "Stock";
            // 
            // tbExistencia
            // 
            this.tbExistencia.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExistencia.Location = new System.Drawing.Point(765, 245);
            this.tbExistencia.Name = "tbExistencia";
            this.tbExistencia.Size = new System.Drawing.Size(425, 44);
            this.tbExistencia.TabIndex = 102;
            // 
            // labelCondicion
            // 
            this.labelCondicion.AutoSize = true;
            this.labelCondicion.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCondicion.Location = new System.Drawing.Point(209, 453);
            this.labelCondicion.Name = "labelCondicion";
            this.labelCondicion.Size = new System.Drawing.Size(0, 36);
            this.labelCondicion.TabIndex = 104;
            // 
            // FProcVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1886, 989);
            this.Controls.Add(this.labelCondicion);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tbExistencia);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbCliente);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbVehiculo);
            this.Controls.Add(this.tbEmpleado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.tbUnidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bBuscarEmpleado);
            this.Controls.Add(this.bBuscarCliente);
            this.Controls.Add(this.bBuscarVehiculo);
            this.Controls.Add(this.tbNCF);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbCondicion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbIdEmpleado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tbIdCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PTitulo);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.tbIdVehiculo);
            this.Controls.Add(this.cbTipofactura);
            this.Name = "FProcVenta";
            this.Text = "FProcVenta";
            this.Load += new System.EventHandler(this.FProcVenta_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.PTitulo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bBuscarVehiculo;
        private System.Windows.Forms.TextBox tbNCF;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbCondicion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bmenu;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIdEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbIdCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbIdVehiculo;
        private System.Windows.Forms.Button bBuscarCliente;
        private System.Windows.Forms.Button bBuscarEmpleado;
        private System.Windows.Forms.ComboBox cbTipofactura;
        private System.Windows.Forms.ToolStripLabel lbTotal;
        private System.Windows.Forms.ToolStripLabel lbItebis;
        private System.Windows.Forms.ToolStripLabel lbSubTotal;
        private System.Windows.Forms.TextBox tbUnidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.TextBox tbEmpleado;
        private System.Windows.Forms.TextBox tbVehiculo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbExistencia;
        private System.Windows.Forms.Label labelCondicion;
    }
}