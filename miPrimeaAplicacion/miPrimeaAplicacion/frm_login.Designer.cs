namespace miPrimeaAplicacion
{
    partial class frm_login
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
            this.lblUsuarioLogin = new System.Windows.Forms.Label();
            this.lblClaveLogin = new System.Windows.Forms.Label();
            this.txtUsuarioLogin = new System.Windows.Forms.TextBox();
            this.txtClaveLogin = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsuarioLogin
            // 
            this.lblUsuarioLogin.AutoSize = true;
            this.lblUsuarioLogin.Location = new System.Drawing.Point(40, 45);
            this.lblUsuarioLogin.Name = "lblUsuarioLogin";
            this.lblUsuarioLogin.Size = new System.Drawing.Size(57, 16);
            this.lblUsuarioLogin.TabIndex = 0;
            this.lblUsuarioLogin.Text = "Usuario:";
            // 
            // lblClaveLogin
            // 
            this.lblClaveLogin.AutoSize = true;
            this.lblClaveLogin.Location = new System.Drawing.Point(40, 85);
            this.lblClaveLogin.Name = "lblClaveLogin";
            this.lblClaveLogin.Size = new System.Drawing.Size(45, 16);
            this.lblClaveLogin.TabIndex = 1;
            this.lblClaveLogin.Text = "Clave:";
            // 
            // txtUsuarioLogin
            // 
            this.txtUsuarioLogin.Location = new System.Drawing.Point(110, 42);
            this.txtUsuarioLogin.Name = "txtUsuarioLogin";
            this.txtUsuarioLogin.Size = new System.Drawing.Size(180, 22);
            this.txtUsuarioLogin.TabIndex = 2;
            // 
            // txtClaveLogin
            // 
            this.txtClaveLogin.Location = new System.Drawing.Point(110, 82);
            this.txtClaveLogin.Name = "txtClaveLogin";
            this.txtClaveLogin.PasswordChar = '*';
            this.txtClaveLogin.Size = new System.Drawing.Size(180, 22);
            this.txtClaveLogin.TabIndex = 3;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(43, 148);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(109, 30);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Iniciar Sesion";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_login
            // 
            this.ClientSize = new System.Drawing.Size(340, 190);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblUsuarioLogin);
            this.Controls.Add(this.lblClaveLogin);
            this.Controls.Add(this.txtUsuarioLogin);
            this.Controls.Add(this.txtClaveLogin);
            this.Controls.Add(this.btnIngresar);
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuarioLogin;
        private System.Windows.Forms.Label lblClaveLogin;
        private System.Windows.Forms.TextBox txtUsuarioLogin;
        private System.Windows.Forms.TextBox txtClaveLogin;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button button1;
    }
}