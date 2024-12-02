
namespace CapaPresentacion
{
    partial class FBuscarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBuscarEmpleado));
            this.DGVDatos = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bBuscar = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.PTitulo = new System.Windows.Forms.Panel();
            this.bUltimo = new System.Windows.Forms.Button();
            this.bSiguiente = new System.Windows.Forms.Button();
            this.bAnterior = new System.Windows.Forms.Button();
            this.bPrimero = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).BeginInit();
            this.panel5.SuspendLayout();
            this.PTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVDatos
            // 
            this.DGVDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVDatos.Location = new System.Drawing.Point(0, 138);
            this.DGVDatos.Name = "DGVDatos";
            this.DGVDatos.RowHeadersWidth = 62;
            this.DGVDatos.RowTemplate.Height = 28;
            this.DGVDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDatos.Size = new System.Drawing.Size(1711, 789);
            this.DGVDatos.TabIndex = 87;
            this.DGVDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDatos_CellContentClick);
            this.DGVDatos.CurrentCellChanged += new System.EventHandler(this.DGVDatos_CurrentCellChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.tbBuscar);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.bBuscar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.ForeColor = System.Drawing.Color.Coral;
            this.panel5.Location = new System.Drawing.Point(0, 69);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1711, 69);
            this.panel5.TabIndex = 86;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscar.Location = new System.Drawing.Point(533, 11);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(559, 53);
            this.tbBuscar.TabIndex = 1;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(99, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(424, 45);
            this.label3.TabIndex = 51;
            this.label3.Text = "Ingrese el dato a buscar";
            // 
            // bBuscar
            // 
            this.bBuscar.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bBuscar.Image = ((System.Drawing.Image)(resources.GetObject("bBuscar.Image")));
            this.bBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bBuscar.Location = new System.Drawing.Point(1105, -1);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(245, 62);
            this.bBuscar.TabIndex = 49;
            this.bBuscar.Text = "Buscar Dato   ";
            this.bBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.ForeColor = System.Drawing.Color.Coral;
            this.panel6.Location = new System.Drawing.Point(-149, 923);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(3138, 5);
            this.panel6.TabIndex = 85;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.ForeColor = System.Drawing.Color.Coral;
            this.panel7.Location = new System.Drawing.Point(0, 64);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(2604, 5);
            this.panel7.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(453, 60);
            this.label2.TabIndex = 83;
            this.label2.Text = "Busqueda Empleado";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Coral;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1711, 69);
            this.panel1.TabIndex = 88;
            // 
            // bCancelar
            // 
            this.bCancelar.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bCancelar.Image = ((System.Drawing.Image)(resources.GetObject("bCancelar.Image")));
            this.bCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCancelar.Location = new System.Drawing.Point(1328, 11);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(185, 73);
            this.bCancelar.TabIndex = 74;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAceptar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bAceptar.Image = ((System.Drawing.Image)(resources.GetObject("bAceptar.Image")));
            this.bAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAceptar.Location = new System.Drawing.Point(1519, 11);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(170, 73);
            this.bAceptar.TabIndex = 73;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // PTitulo
            // 
            this.PTitulo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PTitulo.Controls.Add(this.bCancelar);
            this.PTitulo.Controls.Add(this.bAceptar);
            this.PTitulo.Controls.Add(this.bUltimo);
            this.PTitulo.Controls.Add(this.bSiguiente);
            this.PTitulo.Controls.Add(this.bAnterior);
            this.PTitulo.Controls.Add(this.bPrimero);
            this.PTitulo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PTitulo.Location = new System.Drawing.Point(0, 927);
            this.PTitulo.Name = "PTitulo";
            this.PTitulo.Size = new System.Drawing.Size(1711, 83);
            this.PTitulo.TabIndex = 82;
            // 
            // bUltimo
            // 
            this.bUltimo.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUltimo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bUltimo.Image = ((System.Drawing.Image)(resources.GetObject("bUltimo.Image")));
            this.bUltimo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bUltimo.Location = new System.Drawing.Point(541, 11);
            this.bUltimo.Name = "bUltimo";
            this.bUltimo.Size = new System.Drawing.Size(185, 73);
            this.bUltimo.TabIndex = 72;
            this.bUltimo.Text = "Ultimo";
            this.bUltimo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bUltimo.UseVisualStyleBackColor = true;
            this.bUltimo.Click += new System.EventHandler(this.bUltimo_Click);
            // 
            // bSiguiente
            // 
            this.bSiguiente.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSiguiente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("bSiguiente.Image")));
            this.bSiguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSiguiente.Location = new System.Drawing.Point(365, 11);
            this.bSiguiente.Name = "bSiguiente";
            this.bSiguiente.Size = new System.Drawing.Size(170, 73);
            this.bSiguiente.TabIndex = 71;
            this.bSiguiente.Text = "Siguiente";
            this.bSiguiente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bSiguiente.UseVisualStyleBackColor = true;
            this.bSiguiente.Click += new System.EventHandler(this.bSiguiente_Click);
            // 
            // bAnterior
            // 
            this.bAnterior.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAnterior.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bAnterior.Image = ((System.Drawing.Image)(resources.GetObject("bAnterior.Image")));
            this.bAnterior.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAnterior.Location = new System.Drawing.Point(189, 11);
            this.bAnterior.Name = "bAnterior";
            this.bAnterior.Size = new System.Drawing.Size(170, 73);
            this.bAnterior.TabIndex = 70;
            this.bAnterior.Text = "Anterior";
            this.bAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bAnterior.UseVisualStyleBackColor = true;
            this.bAnterior.Click += new System.EventHandler(this.bAnterior_Click);
            // 
            // bPrimero
            // 
            this.bPrimero.Cursor = System.Windows.Forms.Cursors.Default;
            this.bPrimero.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPrimero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bPrimero.Image = ((System.Drawing.Image)(resources.GetObject("bPrimero.Image")));
            this.bPrimero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bPrimero.Location = new System.Drawing.Point(13, 10);
            this.bPrimero.Name = "bPrimero";
            this.bPrimero.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bPrimero.Size = new System.Drawing.Size(170, 73);
            this.bPrimero.TabIndex = 69;
            this.bPrimero.Text = "Primero";
            this.bPrimero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bPrimero.UseVisualStyleBackColor = true;
            this.bPrimero.Click += new System.EventHandler(this.bPrimero_Click);
            // 
            // FBuscarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1711, 1010);
            this.Controls.Add(this.DGVDatos);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FBuscarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FBuscarEmpleado";
            this.Load += new System.EventHandler(this.FBuscarEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.PTitulo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVDatos;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Panel PTitulo;
        private System.Windows.Forms.Button bUltimo;
        private System.Windows.Forms.Button bSiguiente;
        private System.Windows.Forms.Button bAnterior;
        private System.Windows.Forms.Button bPrimero;
    }
}