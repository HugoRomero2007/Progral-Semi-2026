using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
            this.dataGridView1.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(dataGridView1_RowHeaderMouseClick);
            ActualizarDatos();
        }

        private void ActualizarDatos()
        {
            try
            {
                string sql = "SELECT * FROM usuarios_usss126226";
                dsUsuarios = objConexion.crearDs(sql);

                if (dsUsuarios.Tables.Count > 0 && dsUsuarios.Tables[0].Rows.Count > 0)
                {
                    dataGridView1.DataSource = dsUsuarios.Tables[0];
                    posicion = 0;
                    MostrarDatos();

                    if (dataGridView1.Rows.Count > 0)
                    {
                        dataGridView1.ClearSelection();
                        dataGridView1.Rows[0].Selected = true;
                    }
                }
                else
                {
                    dataGridView1.DataSource = null;
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarDatos()
        {
            try
            {
                DataTable tabla = dsUsuarios.Tables[0];
                if (tabla.Rows.Count > 0 && posicion >= 0 && posicion < tabla.Rows.Count)
                {
                    DataRow fila = tabla.Rows[posicion];
                    txtId.Text = fila[0].ToString();             // idUsuario
                    txtUsuario.Text = fila[1].ToString();        // usuario
                    txtClave.Text = fila[2].ToString();          // clave
                    txtConfirmarClave.Text = fila[2].ToString(); // confirmar clave
                    txtNombre.Text = fila[3].ToString();         // nombre
                    txtDireccion.Text = fila[4].ToString();      // dirección
                    txtTelefono.Text = fila[5].ToString();       // teléfono
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text;
            string confirmar = txtConfirmarClave.Text;

            if (usuario.Length < 6 || usuario.Length > 16)
            {
                MessageBox.Show("El usuario debe tener un mínimo de 6 caracteres y un máximo de 16.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return false;
            }

            if (clave != confirmar)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor verifique.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmarClave.Focus();
                return false;
            }

            bool tieneLetras = false;
            bool tieneNumeros = false;
            foreach (char c in clave)
            {
                if (char.IsLetter(c)) tieneLetras = true;
                if (char.IsDigit(c)) tieneNumeros = true;
            }

            if (!tieneLetras || !tieneNumeros)
            {
                MessageBox.Show("La clave debe contener obligatoriamente letras y números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClave.Focus();
                return false;
            }

            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                string[] datos = {
                    txtUsuario.Text.Trim(),
                    txtClave.Text.Trim(),
                    txtNombre.Text.Trim(),
                    txtDireccion.Text.Trim(),
                    txtTelefono.Text.Trim()
                };

                // SE INCLUYE EL SEGUNDO PARÁMETRO ("nuevo")
                string respuesta = objConexion.mantenimiento_usuarios_usss126226(datos, "nuevo");

                MessageBox.Show("Usuario agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarDatos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Seleccione un registro de la tabla para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCampos()) return;

            try
            {
                string[] datos = {
                    txtUsuario.Text.Trim(),
                    txtClave.Text.Trim(),
                    txtNombre.Text.Trim(),
                    txtDireccion.Text.Trim(),
                    txtTelefono.Text.Trim(),
                    txtId.Text.Trim()
                };

                // SE INCLUYE EL SEGUNDO PARÁMETRO ("modificar")
                string respuesta = objConexion.mantenimiento_usuarios_usss126226(datos, "modificar");

                MessageBox.Show("Usuario modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Seleccione un registro de la tabla para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    string[] datos = { "", "", "", "", "", txtId.Text.Trim() };

                    // SE INCLUYE EL SEGUNDO PARÁMETRO ("eliminar")
                    string respuesta = objConexion.mantenimiento_usuarios_usss126226(datos, "eliminar");

                    MessageBox.Show("Usuario eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    posicion = 0;
                    ActualizarDatos();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtUsuario.Text = "";
            txtClave.Text = "";
            txtConfirmarClave.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtUsuario.Focus();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            DataTable tabla = dsUsuarios.Tables[0];
            if (tabla.Rows.Count > 0)
            {
                posicion = 0;
                dataGridView1.ClearSelection();
                dataGridView1.Rows[posicion].Selected = true;
                MostrarDatos();
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                dataGridView1.ClearSelection();
                dataGridView1.Rows[posicion].Selected = true;
                MostrarDatos();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            DataTable tabla = dsUsuarios.Tables[0];
            if (posicion < tabla.Rows.Count - 1)
            {
                posicion++;
                dataGridView1.ClearSelection();
                dataGridView1.Rows[posicion].Selected = true;
                MostrarDatos();
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            DataTable tabla = dsUsuarios.Tables[0];
            if (tabla.Rows.Count > 0)
            {
                posicion = tabla.Rows.Count - 1;
                dataGridView1.ClearSelection();
                dataGridView1.Rows[posicion].Selected = true;
                MostrarDatos();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                posicion = e.RowIndex;
                MostrarDatos();
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                posicion = e.RowIndex;
                MostrarDatos();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_login loginForm = new frm_login();
            loginForm.Show();
            this.Close();
        }
    }
}