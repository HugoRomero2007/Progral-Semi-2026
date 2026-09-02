namespace ImpuestoActividadesEconomicas
{
    partial class Form1
    {
       
        private System.ComponentModel.IContainer components = null;

      
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grpResultados = new System.Windows.Forms.GroupBox();
            this.lblResultadoImpuesto = new System.Windows.Forms.Label();
            this.lblResultadoRango = new System.Windows.Forms.Label();
            this.dgvTablaImpuestos = new System.Windows.Forms.DataGridView();
            this.colNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdicional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaImpuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Crimson;
            this.lblTitulo.Location = new System.Drawing.Point(211, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(329, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Sistema para calcular los impuestos \r\n";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSubtitulo.Location = new System.Drawing.Point(236, 43);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(269, 19);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Impuesto a las Actividades Económicas";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(25, 90);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(206, 17);
            this.lblMonto.TabIndex = 2;
            this.lblMonto.Text = "Monto Actividad Económica ($):";
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMonto.Location = new System.Drawing.Point(240, 87);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(160, 25);
            this.txtMonto.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.Black;
            this.btnCalcular.Location = new System.Drawing.Point(420, 83);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(120, 32);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(550, 83);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 32);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // grpResultados
            // 
            this.grpResultados.Controls.Add(this.lblResultadoImpuesto);
            this.grpResultados.Controls.Add(this.lblResultadoRango);
            this.grpResultados.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpResultados.Location = new System.Drawing.Point(28, 130);
            this.grpResultados.Name = "grpResultados";
            this.grpResultados.Size = new System.Drawing.Size(680, 85);
            this.grpResultados.TabIndex = 6;
            this.grpResultados.TabStop = false;
            this.grpResultados.Text = "Resultado del Cálculo";
            // 
            // lblResultadoImpuesto
            // 
            this.lblResultadoImpuesto.AutoSize = true;
            this.lblResultadoImpuesto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblResultadoImpuesto.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblResultadoImpuesto.Location = new System.Drawing.Point(15, 52);
            this.lblResultadoImpuesto.Name = "lblResultadoImpuesto";
            this.lblResultadoImpuesto.Size = new System.Drawing.Size(160, 21);
            this.lblResultadoImpuesto.TabIndex = 1;
            this.lblResultadoImpuesto.Text = "Valor a pagar: $0.00";
            // 
            // lblResultadoRango
            // 
            this.lblResultadoRango.AutoSize = true;
            this.lblResultadoRango.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoRango.Location = new System.Drawing.Point(15, 25);
            this.lblResultadoRango.Name = "lblResultadoRango";
            this.lblResultadoRango.Size = new System.Drawing.Size(136, 17);
            this.lblResultadoRango.TabIndex = 0;
            this.lblResultadoRango.Text = "Tramo aplicado: N/A";
            // 
            // dgvTablaImpuestos
            // 
            this.dgvTablaImpuestos.AllowUserToAddRows = false;
            this.dgvTablaImpuestos.AllowUserToDeleteRows = false;
            this.dgvTablaImpuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaImpuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNum,
            this.colDesde,
            this.colHasta,
            this.colPrecio,
            this.colAdicional});
            this.dgvTablaImpuestos.Location = new System.Drawing.Point(28, 230);
            this.dgvTablaImpuestos.Name = "dgvTablaImpuestos";
            this.dgvTablaImpuestos.ReadOnly = true;
            this.dgvTablaImpuestos.Size = new System.Drawing.Size(680, 220);
            this.dgvTablaImpuestos.TabIndex = 7;
            // 
            // colNum
            // 
            this.colNum.HeaderText = "No.";
            this.colNum.Name = "colNum";
            this.colNum.ReadOnly = true;
            this.colNum.Width = 50;
            // 
            // colDesde
            // 
            this.colDesde.HeaderText = "Desde ($)";
            this.colDesde.Name = "colDesde";
            this.colDesde.ReadOnly = true;
            this.colDesde.Width = 140;
            // 
            // colHasta
            // 
            this.colHasta.HeaderText = "Hasta ($)";
            this.colHasta.Name = "colHasta";
            this.colHasta.ReadOnly = true;
            this.colHasta.Width = 140;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio Fijo ($)";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            this.colPrecio.Width = 140;
            // 
            // colAdicional
            // 
            this.colAdicional.HeaderText = "Adicional ($)";
            this.colAdicional.Name = "colAdicional";
            this.colAdicional.ReadOnly = true;
            this.colAdicional.Width = 140;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 470);
            this.Controls.Add(this.dgvTablaImpuestos);
            this.Controls.Add(this.grpResultados);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de Impuesto a las Actividades Económicas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpResultados.ResumeLayout(false);
            this.grpResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaImpuestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox grpResultados;
        private System.Windows.Forms.Label lblResultadoImpuesto;
        private System.Windows.Forms.Label lblResultadoRango;
        private System.Windows.Forms.DataGridView dgvTablaImpuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdicional;
    }
}