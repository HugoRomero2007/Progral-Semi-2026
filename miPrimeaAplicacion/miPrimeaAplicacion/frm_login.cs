using System;
using System.Data;
using System.Windows.Forms;

namespace miPrimeaAplicacion
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuarioLogin.Text.Trim();
            string clave = txtClaveLogin.Text;

            // Consulta para verificar si el usuario y clave están registrados en la base de datos[cite: 1]
            string consulta = $"SELECT COUNT(*) FROM usuarios_usss126226 WHERE usuario = '{usuario}' AND clave = '{clave}'";

            Conexion objConexion = new Conexion();
            DataSet ds = objConexion.crearDs(consulta);

            // CORRECCIÓN: Se usa Tables[0] porque SELECT COUNT(*) devuelve una tabla genérica sin nombre específico
            int registros = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

            // Si el usuario está registrado, se le da acceso; de lo contrario se deniega[cite: 1]
            if (registros > 0)
            {
                MessageBox.Show("¡Acceso concedido al sistema!", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abre el formulario de usuarios y oculta el login
                frm_usuario formUsuario = new frm_usuario();
                formUsuario.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Acceso denegado.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuarioLogin.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuarioLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}