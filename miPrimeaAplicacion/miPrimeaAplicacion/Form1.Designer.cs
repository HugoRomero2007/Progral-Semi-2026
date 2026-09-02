namespace ConversorArea
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
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblDe = new System.Windows.Forms.Label();
            this.cmbDe = new System.Windows.Forms.ComboBox();
            this.lblA = new System.Windows.Forms.Label();
            this.cmbA = new System.Windows.Forms.ComboBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grpResultado = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.grpResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Navy;
            this.lblTitulo.Location = new System.Drawing.Point(174, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(195, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Conversor de areas \r\n";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.Location = new System.Drawing.Point(157, 55);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(278, 17);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Unidades Agrarias y Métricas de El Salvador";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(40, 95);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(115, 17);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor a convertir:";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtValor.Location = new System.Drawing.Point(160, 92);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(320, 25);
            this.txtValor.TabIndex = 3;
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDe.Location = new System.Drawing.Point(40, 135);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(29, 17);
            this.lblDe.TabIndex = 4;
            this.lblDe.Text = "De:";
            // 
            // cmbDe
            // 
            this.cmbDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDe.FormattingEnabled = true;
            this.cmbDe.Location = new System.Drawing.Point(160, 132);
            this.cmbDe.Name = "cmbDe";
            this.cmbDe.Size = new System.Drawing.Size(320, 25);
            this.cmbDe.TabIndex = 5;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(40, 175);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(21, 17);
            this.lblA.TabIndex = 6;
            this.lblA.Text = "A:";
            // 
            // cmbA
            // 
            this.cmbA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbA.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbA.FormattingEnabled = true;
            this.cmbA.Location = new System.Drawing.Point(160, 172);
            this.cmbA.Name = "cmbA";
            this.cmbA.Size = new System.Drawing.Size(320, 25);
            this.cmbA.TabIndex = 7;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.ForeColor = System.Drawing.Color.Black;
            this.btnConvertir.Location = new System.Drawing.Point(160, 215);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(155, 32);
            this.btnConvertir.TabIndex = 8;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(325, 215);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(155, 32);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // grpResultado
            // 
            this.grpResultado.Controls.Add(this.lblResultado);
            this.grpResultado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpResultado.Location = new System.Drawing.Point(40, 265);
            this.grpResultado.Name = "grpResultado";
            this.grpResultado.Size = new System.Drawing.Size(440, 80);
            this.grpResultado.TabIndex = 10;
            this.grpResultado.TabStop = false;
            this.grpResultado.Text = "Resultado";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblResultado.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblResultado.Location = new System.Drawing.Point(15, 35);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(136, 21);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "0.00 equivalente";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 375);
            this.Controls.Add(this.grpResultado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.cmbA);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.cmbDe);
            this.Controls.Add(this.lblDe);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de Superficie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpResultado.ResumeLayout(false);
            this.grpResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.ComboBox cmbDe;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.ComboBox cmbA;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox grpResultado;
        private System.Windows.Forms.Label lblResultado;
    }
}