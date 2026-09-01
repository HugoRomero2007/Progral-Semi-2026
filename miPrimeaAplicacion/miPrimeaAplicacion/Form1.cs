using System;
using System.Windows.Forms;

namespace miPrimeaAplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            dgvTabla.Rows.Clear();

            bool esMesValido = int.TryParse(txtMeses.Text, out int nMeses) && nMeses > 0;
            bool esMontoValido = double.TryParse(txtMonto.Text, out double montoMensual) && montoMensual >= 0;

            if (esMesValido && esMontoValido)
            {
                double acumulado = 0;

                for (int i = 1; i <= nMeses; i++)
                {
                    acumulado += montoMensual;
                    dgvTabla.Rows.Add(i, $"${montoMensual:F2}", $"${acumulado:F2}");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores válidos en ambos campos.",
                                "Datos Inválidos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtMeses.Focus();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMeses.Clear();
            txtMonto.Clear();
            dgvTabla.Rows.Clear();
            txtMeses.Focus();
        }
    }
}