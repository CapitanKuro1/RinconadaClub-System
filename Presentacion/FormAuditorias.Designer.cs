namespace Presentacion
{
    partial class FormAuditoria
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvAuditoria = new System.Windows.Forms.DataGridView();
            this.btnAccionesPorUsuario = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnAccionesFrecuentes = new System.Windows.Forms.Button();
            this.btnAuditoriaPorDia = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAuditoria
            // 
            this.dgvAuditoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuditoria.Location = new System.Drawing.Point(354, 12);
            this.dgvAuditoria.Name = "dgvAuditoria";
            this.dgvAuditoria.RowHeadersWidth = 51;
            this.dgvAuditoria.RowTemplate.Height = 24;
            this.dgvAuditoria.Size = new System.Drawing.Size(637, 169);
            this.dgvAuditoria.TabIndex = 0;
            // 
            // btnAccionesPorUsuario
            // 
            this.btnAccionesPorUsuario.Location = new System.Drawing.Point(82, 59);
            this.btnAccionesPorUsuario.Name = "btnAccionesPorUsuario";
            this.btnAccionesPorUsuario.Size = new System.Drawing.Size(153, 61);
            this.btnAccionesPorUsuario.TabIndex = 2;
            this.btnAccionesPorUsuario.Text = "Acciones por Usuario";
            this.btnAccionesPorUsuario.UseVisualStyleBackColor = true;
            this.btnAccionesPorUsuario.Click += new System.EventHandler(this.btnAccionesPorUsuario_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(354, 187);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(637, 266);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // btnAccionesFrecuentes
            // 
            this.btnAccionesFrecuentes.Location = new System.Drawing.Point(82, 147);
            this.btnAccionesFrecuentes.Name = "btnAccionesFrecuentes";
            this.btnAccionesFrecuentes.Size = new System.Drawing.Size(153, 61);
            this.btnAccionesFrecuentes.TabIndex = 9;
            this.btnAccionesFrecuentes.Text = "Acciones Frecuentes";
            this.btnAccionesFrecuentes.UseVisualStyleBackColor = true;
            this.btnAccionesFrecuentes.Click += new System.EventHandler(this.btnAccionesFrecuentes_Click);
            // 
            // btnAuditoriaPorDia
            // 
            this.btnAuditoriaPorDia.Location = new System.Drawing.Point(82, 231);
            this.btnAuditoriaPorDia.Name = "btnAuditoriaPorDia";
            this.btnAuditoriaPorDia.Size = new System.Drawing.Size(153, 61);
            this.btnAuditoriaPorDia.TabIndex = 10;
            this.btnAuditoriaPorDia.Text = "Auditorías por Día";
            this.btnAuditoriaPorDia.UseVisualStyleBackColor = true;
            this.btnAuditoriaPorDia.Click += new System.EventHandler(this.btnAuditoriaPorDia_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(82, 314);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(153, 61);
            this.btnRegresar.TabIndex = 11;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FormAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 478);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAuditoriaPorDia);
            this.Controls.Add(this.btnAccionesFrecuentes);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnAccionesPorUsuario);
            this.Controls.Add(this.dgvAuditoria);
            this.Name = "FormAuditoria";
            this.Text = "Auditorias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAuditoria;
        private System.Windows.Forms.Button btnAccionesPorUsuario;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnAccionesFrecuentes;
        private System.Windows.Forms.Button btnAuditoriaPorDia;
        private System.Windows.Forms.Button btnRegresar;
    }
}