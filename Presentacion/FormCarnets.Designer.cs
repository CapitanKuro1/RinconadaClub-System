namespace Presentacion
{
    partial class FormCarnet
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
            this.dgvCarnets = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblIdCarnet = new System.Windows.Forms.Label();
            this.lblFechaEmision = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblSocio = new System.Windows.Forms.Label();
            this.txtIdCarnet = new System.Windows.Forms.TextBox();
            this.dtFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.cbSocio = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarnets)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCarnets
            // 
            this.dgvCarnets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarnets.Location = new System.Drawing.Point(409, 32);
            this.dgvCarnets.Name = "dgvCarnets";
            this.dgvCarnets.RowHeadersWidth = 51;
            this.dgvCarnets.RowTemplate.Height = 24;
            this.dgvCarnets.Size = new System.Drawing.Size(486, 178);
            this.dgvCarnets.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(97, 241);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(101, 36);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(229, 241);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(101, 36);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(229, 301);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(101, 36);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(97, 301);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 36);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblIdCarnet
            // 
            this.lblIdCarnet.AutoSize = true;
            this.lblIdCarnet.Location = new System.Drawing.Point(79, 32);
            this.lblIdCarnet.Name = "lblIdCarnet";
            this.lblIdCarnet.Size = new System.Drawing.Size(62, 16);
            this.lblIdCarnet.TabIndex = 5;
            this.lblIdCarnet.Text = "ID Carnet";
            // 
            // lblFechaEmision
            // 
            this.lblFechaEmision.AutoSize = true;
            this.lblFechaEmision.Location = new System.Drawing.Point(79, 79);
            this.lblFechaEmision.Name = "lblFechaEmision";
            this.lblFechaEmision.Size = new System.Drawing.Size(96, 16);
            this.lblFechaEmision.TabIndex = 6;
            this.lblFechaEmision.Text = "Fecha Emisión";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(79, 124);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(50, 16);
            this.lblEstado.TabIndex = 7;
            this.lblEstado.Text = "Estado";
            // 
            // lblSocio
            // 
            this.lblSocio.AutoSize = true;
            this.lblSocio.Location = new System.Drawing.Point(79, 173);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(42, 16);
            this.lblSocio.TabIndex = 8;
            this.lblSocio.Text = "Socio";
            // 
            // txtIdCarnet
            // 
            this.txtIdCarnet.Location = new System.Drawing.Point(195, 32);
            this.txtIdCarnet.Name = "txtIdCarnet";
            this.txtIdCarnet.Size = new System.Drawing.Size(100, 22);
            this.txtIdCarnet.TabIndex = 9;
            // 
            // dtFechaEmision
            // 
            this.dtFechaEmision.Location = new System.Drawing.Point(195, 79);
            this.dtFechaEmision.Name = "dtFechaEmision";
            this.dtFechaEmision.Size = new System.Drawing.Size(200, 22);
            this.dtFechaEmision.TabIndex = 10;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbEstado.Location = new System.Drawing.Point(195, 115);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 24);
            this.cbEstado.TabIndex = 11;
            // 
            // cbSocio
            // 
            this.cbSocio.FormattingEnabled = true;
            this.cbSocio.Location = new System.Drawing.Point(195, 170);
            this.cbSocio.Name = "cbSocio";
            this.cbSocio.Size = new System.Drawing.Size(121, 24);
            this.cbSocio.TabIndex = 12;
            // 
            // FormCarnet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 363);
            this.Controls.Add(this.cbSocio);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.dtFechaEmision);
            this.Controls.Add(this.txtIdCarnet);
            this.Controls.Add(this.lblSocio);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblFechaEmision);
            this.Controls.Add(this.lblIdCarnet);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgvCarnets);
            this.Name = "FormCarnet";
            this.Text = "Carnets";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarnets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCarnets;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblIdCarnet;
        private System.Windows.Forms.Label lblFechaEmision;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblSocio;
        private System.Windows.Forms.TextBox txtIdCarnet;
        private System.Windows.Forms.DateTimePicker dtFechaEmision;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.ComboBox cbSocio;
    }
}