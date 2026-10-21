using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace miPrimeaAplicacion
{
    public partial class frm_usuario : Form
    {
        Conexion objConexion = new Conexion();
        DataSet dsUsuarios = new DataSet();
        int posicion = 0;

        public frm_usuario()
        {
            InitializeComponent();
        }

        private void frm_usuario_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            string sql = "SELECT * FROM usuarios_usss126226";
            dsUsuarios = objConexion.crearDs(sql);

            if (dsUsuarios.Tables["usuarios_usss126226"].Rows.Count > 0)
            {
                MostrarRegistro();
            }
        }

        private void MostrarRegistro()
        {
            if (dsUsuarios.Tables["usuarios_usss126226"].Rows.Count > 0)
            {
                DataRow fila = dsUsuarios.Tables["usuarios_usss126226"].Rows[posicion];
                txtUsuario.Text = fila["usuario"].ToString();
                txtClave.Text = fila["clave"].ToString();
                txtConfirmarClave.Text = fila["clave"].ToString();
                txtNombre.Text = fila["nombre"].ToString();
                txtDireccion.Text = fila["dirección"].ToString();
                txtTelefono.Text = fila["teléfono"].ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text;
            string confirmarClave = txtConfirmarClave.Text;

            // 1. Validar que el usuario tenga de 6 a 16 caracteres
            if (usuario.Length < 6 || usuario.Length > 16)
            {
                MessageBox.Show("El usuario debe tener como mínimo 6 caracteres y 16 como máximo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            // 2. Validar coincidencia de claves[cite: 1]
            if (clave != confirmarClave)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor verifique.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmarClave.Focus();
                return;
            }

            // 3. Validar que la clave lleve obligatoriamente letras y números[cite: 1]
            bool tieneLetras = Regex.IsMatch(clave, "[a-zA-Z]");
            bool tieneNumeros = Regex.IsMatch(clave, "[0-9]");

            if (!tieneLetras || !tieneNumeros)
            {
                MessageBox.Show("La contraseña debe llevar obligatoriamente letras y números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClave.Focus();
                return;
            }

            // Inserción en la base de datos
            string sql = $"INSERT INTO usuarios_usss126226 (usuario, clave, nombre, dirección, teléfono) VALUES ('{usuario}', '{clave}', '{txtNombre.Text.Trim()}', '{txtDireccion.Text.Trim()}', '{txtTelefono.Text.Trim()}')";

            bool exito = objConexion.mantenimiento_usuarios_usss126226(sql);

            if (exito)
            {
                MessageBox.Show("¡Usuario registrado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
            }
            else
            {
                MessageBox.Show("Error al guardar el usuario en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dsUsuarios.Tables["usuarios_usss126226"].Rows.Count > 0)
            {
                string idUsuario = dsUsuarios.Tables["usuarios_usss126226"].Rows[posicion]["idUsuario"].ToString();
                string sql = $"UPDATE usuarios_usss126226 SET usuario='{txtUsuario.Text.Trim()}', clave='{txtClave.Text}', nombre='{txtNombre.Text.Trim()}', dirección='{txtDireccion.Text.Trim()}', teléfono='{txtTelefono.Text.Trim()}' WHERE idUsuario={idUsuario}";

                if (objConexion.mantenimiento_usuarios_usss126226(sql))
                {
                    MessageBox.Show("Usuario modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dsUsuarios.Tables["usuarios_usss126226"].Rows.Count > 0)
            {
                string idUsuario = dsUsuarios.Tables["usuarios_usss126226"].Rows[posicion]["idUsuario"].ToString();
                string sql = $"DELETE FROM usuarios_usss126226 WHERE idUsuario={idUsuario}";

                if (objConexion.mantenimiento_usuarios_usss126226(sql))
                {
                    MessageBox.Show("Usuario eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    posicion = 0;
                    CargarDatos();
                }
            }
        }

        // ==========================================
        // BOTONES DE NAVEGACIÓN (Punto del examen)[cite: 1]
        // ==========================================

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            posicion = 0;
            MostrarRegistro();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                MostrarRegistro();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (posicion < dsUsuarios.Tables["usuarios_usss126226"].Rows.Count - 1)
            {
                posicion++;
                MostrarRegistro();
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (dsUsuarios.Tables["usuarios_usss126226"].Rows.Count > 0)
            {
                posicion = dsUsuarios.Tables["usuarios_usss126226"].Rows.Count - 1;
                MostrarRegistro();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_login login = new frm_login();

            
            login.Show();

            this.Close();

        }
    }
}