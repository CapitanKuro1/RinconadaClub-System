namespace Presentacion
{
    partial class FormInvitados
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
            this.dgvInvitados = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblIdInvitado = new System.Windows.Forms.Label();
            this.lblNombreInvitado = new System.Windows.Forms.Label();
            this.lblFechaVisita = new System.Windows.Forms.Label();
            this.lblDniInvitado = new System.Windows.Forms.Label();
            this.lblSocio = new System.Windows.Forms.Label();
            this.txtIdInvitado = new System.Windows.Forms.TextBox();
            this.txtNombreInvitado = new System.Windows.Forms.TextBox();
            this.txtDniInvitado = new System.Windows.Forms.TextBox();
            this.dtFechaVisita = new System.Windows.Forms.DateTimePicker();
            this.cbSocio = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvitados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInvitados
            // 
            this.dgvInvitados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvitados.Location = new System.Drawing.Point(386, 32);
            this.dgvInvitados.Name = "dgvInvitados";
            this.dgvInvitados.RowHeadersWidth = 51;
            this.dgvInvitados.RowTemplate.Height = 24;
            this.dgvInvitados.Size = new System.Drawing.Size(450, 183);
            this.dgvInvitados.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(58, 232);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(106, 31);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(201, 232);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(106, 31);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(201, 294);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(106, 31);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(58, 294);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(106, 31);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblIdInvitado
            // 
            this.lblIdInvitado.AutoSize = true;
            this.lblIdInvitado.Location = new System.Drawing.Point(55, 32);
            this.lblIdInvitado.Name = "lblIdInvitado";
            this.lblIdInvitado.Size = new System.Drawing.Size(70, 16);
            this.lblIdInvitado.TabIndex = 5;
            this.lblIdInvitado.Text = "ID Invitado";
            // 
            // lblNombreInvitado
            // 
            this.lblNombreInvitado.AutoSize = true;
            this.lblNombreInvitado.Location = new System.Drawing.Point(55, 67);
            this.lblNombreInvitado.Name = "lblNombreInvitado";
            this.lblNombreInvitado.Size = new System.Drawing.Size(106, 16);
            this.lblNombreInvitado.TabIndex = 6;
            this.lblNombreInvitado.Text = "Nombre Invitado";
            // 
            // lblFechaVisita
            // 
            this.lblFechaVisita.AutoSize = true;
            this.lblFechaVisita.Location = new System.Drawing.Point(55, 140);
            this.lblFechaVisita.Name = "lblFechaVisita";
            this.lblFechaVisita.Size = new System.Drawing.Size(81, 16);
            this.lblFechaVisita.TabIndex = 8;
            this.lblFechaVisita.Text = "Fecha Visita";
            // 
            // lblDniInvitado
            // 
            this.lblDniInvitado.AutoSize = true;
            this.lblDniInvitado.Location = new System.Drawing.Point(55, 105);
            this.lblDniInvitado.Name = "lblDniInvitado";
            this.lblDniInvitado.Size = new System.Drawing.Size(80, 16);
            this.lblDniInvitado.TabIndex = 7;
            this.lblDniInvitado.Text = "DNI Invitado";
            // 
            // lblSocio
            // 
            this.lblSocio.AutoSize = true;
            this.lblSocio.Location = new System.Drawing.Point(55, 179);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(102, 16);
            this.lblSocio.TabIndex = 9;
            this.lblSocio.Text = "Socio que invita";
            // 
            // txtIdInvitado
            // 
            this.txtIdInvitado.Location = new System.Drawing.Point(201, 32);
            this.txtIdInvitado.Name = "txtIdInvitado";
            this.txtIdInvitado.Size = new System.Drawing.Size(100, 22);
            this.txtIdInvitado.TabIndex = 10;
            // 
            // txtNombreInvitado
            // 
            this.txtNombreInvitado.Location = new System.Drawing.Point(201, 67);
            this.txtNombreInvitado.Name = "txtNombreInvitado";
            this.txtNombreInvitado.Size = new System.Drawing.Size(100, 22);
            this.txtNombreInvitado.TabIndex = 11;
            // 
            // txtDniInvitado
            // 
            this.txtDniInvitado.Location = new System.Drawing.Point(201, 102);
            this.txtDniInvitado.Name = "txtDniInvitado";
            this.txtDniInvitado.Size = new System.Drawing.Size(100, 22);
            this.txtDniInvitado.TabIndex = 12;
            // 
            // dtFechaVisita
            // 
            this.dtFechaVisita.Location = new System.Drawing.Point(201, 133);
            this.dtFechaVisita.Name = "dtFechaVisita";
            this.dtFechaVisita.Size = new System.Drawing.Size(200, 22);
            this.dtFechaVisita.TabIndex = 13;
            // 
            // cbSocio
            // 
            this.cbSocio.FormattingEnabled = true;
            this.cbSocio.Location = new System.Drawing.Point(201, 179);
            this.cbSocio.Name = "cbSocio";
            this.cbSocio.Size = new System.Drawing.Size(121, 24);
            this.cbSocio.TabIndex = 14;
            // 
            // FormInvitados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 406);
            this.Controls.Add(this.cbSocio);
            this.Controls.Add(this.dtFechaVisita);
            this.Controls.Add(this.txtDniInvitado);
            this.Controls.Add(this.txtNombreInvitado);
            this.Controls.Add(this.txtIdInvitado);
            this.Controls.Add(this.lblSocio);
            this.Controls.Add(this.lblFechaVisita);
            this.Controls.Add(this.lblDniInvitado);
            this.Controls.Add(this.lblNombreInvitado);
            this.Controls.Add(this.lblIdInvitado);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgvInvitados);
            this.Name = "FormInvitados";
            this.Text = "Invitados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvitados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInvitados;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblIdInvitado;
        private System.Windows.Forms.Label lblNombreInvitado;
        private System.Windows.Forms.Label lblFechaVisita;
        private System.Windows.Forms.Label lblDniInvitado;
        private System.Windows.Forms.Label lblSocio;
        private System.Windows.Forms.TextBox txtIdInvitado;
        private System.Windows.Forms.TextBox txtNombreInvitado;
        private System.Windows.Forms.TextBox txtDniInvitado;
        private System.Windows.Forms.DateTimePicker dtFechaVisita;
        private System.Windows.Forms.ComboBox cbSocio;
    }
}