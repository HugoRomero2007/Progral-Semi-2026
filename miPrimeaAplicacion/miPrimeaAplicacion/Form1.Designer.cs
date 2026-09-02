namespace SistemaEstadistico
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.TextBox txtNumeros;

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;

        private System.Windows.Forms.GroupBox grpResultados;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblMediana;
        private System.Windows.Forms.Label lblModa;
        private System.Windows.Forms.Label lblVarianza;
        private System.Windows.Forms.Label lblDesviacionEstandar;
        private System.Windows.Forms.Label lblDesviacionTipica;
        private System.Windows.Forms.Label lblRango;

        private System.Windows.Forms.GroupBox grpFrecuencia;
        private System.Windows.Forms.DataGridView dgvFrecuencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrecuencia;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grpResultados = new System.Windows.Forms.GroupBox();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblMediana = new System.Windows.Forms.Label();
            this.lblModa = new System.Windows.Forms.Label();
            this.lblVarianza = new System.Windows.Forms.Label();
            this.lblDesviacionEstandar = new System.Windows.Forms.Label();
            this.lblDesviacionTipica = new System.Windows.Forms.Label();
            this.lblRango = new System.Windows.Forms.Label();
            this.grpFrecuencia = new System.Windows.Forms.GroupBox();
            this.dgvFrecuencia = new System.Windows.Forms.DataGridView();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFrecuencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpResultados.SuspendLayout();
            this.grpFrecuencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrecuencia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(283, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(174, 25);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "SISTEMA ESTADÍSTICO";
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruccion.Location = new System.Drawing.Point(4, 87);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(313, 19);
            this.lblInstruccion.TabIndex = 4;
            this.lblInstruccion.Text = "Ingrese los números separados por comas:";
            // 
            // txtNumeros
            // 
            this.txtNumeros.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNumeros.Location = new System.Drawing.Point(323, 87);
            this.txtNumeros.Multiline = true;
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(449, 26);
            this.txtNumeros.TabIndex = 0;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalcular.Location = new System.Drawing.Point(612, 194);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(146, 36);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(612, 262);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(146, 36);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // grpResultados
            // 
            this.grpResultados.Controls.Add(this.lblMedia);
            this.grpResultados.Controls.Add(this.lblMediana);
            this.grpResultados.Controls.Add(this.lblModa);
            this.grpResultados.Controls.Add(this.lblVarianza);
            this.grpResultados.Controls.Add(this.lblDesviacionEstandar);
            this.grpResultados.Controls.Add(this.lblDesviacionTipica);
            this.grpResultados.Controls.Add(this.lblRango);
            this.grpResultados.Location = new System.Drawing.Point(47, 194);
            this.grpResultados.Name = "grpResultados";
            this.grpResultados.Size = new System.Drawing.Size(278, 260);
            this.grpResultados.TabIndex = 1;
            this.grpResultados.TabStop = false;
            this.grpResultados.Text = "Resultados estadísticos";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.Location = new System.Drawing.Point(21, 35);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(97, 17);
            this.lblMedia.TabIndex = 0;
            this.lblMedia.Text = "Media aritmética: ";
            // 
            // lblMediana
            // 
            this.lblMediana.AutoSize = true;
            this.lblMediana.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediana.Location = new System.Drawing.Point(21, 68);
            this.lblMediana.Name = "lblMediana";
            this.lblMediana.Size = new System.Drawing.Size(56, 17);
            this.lblMediana.TabIndex = 1;
            this.lblMediana.Text = "Mediana: ";
            // 
            // lblModa
            // 
            this.lblModa.AutoSize = true;
            this.lblModa.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModa.Location = new System.Drawing.Point(21, 101);
            this.lblModa.Name = "lblModa";
            this.lblModa.Size = new System.Drawing.Size(41, 17);
            this.lblModa.TabIndex = 2;
            this.lblModa.Text = "Moda: ";
            // 
            // lblVarianza
            // 
            this.lblVarianza.AutoSize = true;
            this.lblVarianza.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVarianza.Location = new System.Drawing.Point(21, 133);
            this.lblVarianza.Name = "lblVarianza";
            this.lblVarianza.Size = new System.Drawing.Size(59, 17);
            this.lblVarianza.TabIndex = 3;
            this.lblVarianza.Text = "Varianza: ";
            // 
            // lblDesviacionEstandar
            // 
            this.lblDesviacionEstandar.AutoSize = true;
            this.lblDesviacionEstandar.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesviacionEstandar.Location = new System.Drawing.Point(21, 166);
            this.lblDesviacionEstandar.Name = "lblDesviacionEstandar";
            this.lblDesviacionEstandar.Size = new System.Drawing.Size(117, 17);
            this.lblDesviacionEstandar.TabIndex = 4;
            this.lblDesviacionEstandar.Text = "Desviación estándar: ";
            // 
            // lblDesviacionTipica
            // 
            this.lblDesviacionTipica.AutoSize = true;
            this.lblDesviacionTipica.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesviacionTipica.Location = new System.Drawing.Point(21, 199);
            this.lblDesviacionTipica.Name = "lblDesviacionTipica";
            this.lblDesviacionTipica.Size = new System.Drawing.Size(100, 17);
            this.lblDesviacionTipica.TabIndex = 5;
            this.lblDesviacionTipica.Text = "Desviación típica: ";
            // 
            // lblRango
            // 
            this.lblRango.AutoSize = true;
            this.lblRango.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRango.Location = new System.Drawing.Point(21, 229);
            this.lblRango.Name = "lblRango";
            this.lblRango.Size = new System.Drawing.Size(45, 17);
            this.lblRango.TabIndex = 6;
            this.lblRango.Text = "Rango: ";
            // 
            // grpFrecuencia
            // 
            this.grpFrecuencia.Controls.Add(this.dgvFrecuencia);
            this.grpFrecuencia.Location = new System.Drawing.Point(331, 204);
            this.grpFrecuencia.Name = "grpFrecuencia";
            this.grpFrecuencia.Size = new System.Drawing.Size(224, 222);
            this.grpFrecuencia.TabIndex = 0;
            this.grpFrecuencia.TabStop = false;
            this.grpFrecuencia.Text = "Frecuencia";
            // 
            // dgvFrecuencia
            // 
            this.dgvFrecuencia.AllowUserToAddRows = false;
            this.dgvFrecuencia.AllowUserToDeleteRows = false;
            this.dgvFrecuencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFrecuencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrecuencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumero,
            this.colFrecuencia});
            this.dgvFrecuencia.Location = new System.Drawing.Point(6, 0);
            this.dgvFrecuencia.Name = "dgvFrecuencia";
            this.dgvFrecuencia.ReadOnly = true;
            this.dgvFrecuencia.RowHeadersVisible = false;
            this.dgvFrecuencia.Size = new System.Drawing.Size(210, 212);
            this.dgvFrecuencia.TabIndex = 0;
            // 
            // colNumero
            // 
            this.colNumero.HeaderText = "Número";
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            // 
            // colFrecuencia
            // 
            this.colFrecuencia.HeaderText = "Frecuencia";
            this.colFrecuencia.Name = "colFrecuencia";
            this.colFrecuencia.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 503);
            this.Controls.Add(this.grpFrecuencia);
            this.Controls.Add(this.grpResultados);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.lblInstruccion);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Estadístico";
            this.grpResultados.ResumeLayout(false);
            this.grpResultados.PerformLayout();
            this.grpFrecuencia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrecuencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}