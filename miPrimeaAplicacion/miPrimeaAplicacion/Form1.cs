using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SistemaEstadistico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumeros.Text))
            {
                MessageBox.Show(
                    "Ingrese los números separados por comas.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNumeros.Focus();
                return;
            }

            try
            {
                string texto = txtNumeros.Text.Replace(";", ",");

                string[] datos = texto.Split(
                    new char[] { ',' },
                    StringSplitOptions.RemoveEmptyEntries);

                List<double> numeros = new List<double>();

                foreach (string dato in datos)
                {
                    double numero;

                    if (!double.TryParse(dato.Trim(), out numero))
                    {
                        MessageBox.Show(
                            "El valor '" + dato.Trim() + "' no es válido.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return;
                    }

                    numeros.Add(numero);
                }

                if (numeros.Count == 0)
                {
                    MessageBox.Show("Ingrese al menos un número.");
                    return;
                }

                // Ordenar números
                numeros.Sort();

                int cantidad = numeros.Count;

                // MEDIA
                double suma = numeros.Sum();
                double media = suma / cantidad;

                // MEDIANA
                double mediana;

                if (cantidad % 2 == 0)
                {
                    mediana =
                        (numeros[cantidad / 2 - 1] +
                         numeros[cantidad / 2]) / 2;
                }
                else
                {
                    mediana = numeros[cantidad / 2];
                }

                // FRECUENCIAS
                Dictionary<double, int> frecuencias =
                    new Dictionary<double, int>();

                foreach (double numero in numeros)
                {
                    if (frecuencias.ContainsKey(numero))
                        frecuencias[numero]++;
                    else
                        frecuencias.Add(numero, 1);
                }

                // MODA
                int frecuenciaMayor = frecuencias.Values.Max();

                List<double> modas = frecuencias
                    .Where(x => x.Value == frecuenciaMayor)
                    .Select(x => x.Key)
                    .ToList();

                string moda;

                if (frecuenciaMayor == 1)
                {
                    moda = "No existe";
                }
                else
                {
                    moda = string.Join(
                        ", ",
                        modas.Select(x => x.ToString("0.##")));
                }

                // VARIANZA
                double sumaCuadrados = 0;

                foreach (double numero in numeros)
                {
                    sumaCuadrados +=
                        Math.Pow(numero - media, 2);
                }

                double varianza =
                    sumaCuadrados / cantidad;

                // DESVIACIÓN ESTÁNDAR
                double desviacionEstandar =
                    Math.Sqrt(varianza);

                // DESVIACIÓN TÍPICA
                double desviacionTipica =
                    desviacionEstandar;

                // RANGO
                double rango =
                    numeros.Max() - numeros.Min();

                // MOSTRAR RESULTADOS

                lblMedia.Text =
                    "Media aritmética: " +
                    media.ToString("0.00");

                lblMediana.Text =
                    "Mediana: " +
                    mediana.ToString("0.00");

                lblModa.Text =
                    "Moda: " + moda;

                lblVarianza.Text =
                    "Varianza: " +
                    varianza.ToString("0.00");

                lblDesviacionEstandar.Text =
                    "Desviación estándar: " +
                    desviacionEstandar.ToString("0.00");

                lblDesviacionTipica.Text =
                    "Desviación típica: " +
                    desviacionTipica.ToString("0.00");

                lblRango.Text =
                    "Rango: " +
                    rango.ToString("0.00");

                // TABLA DE FRECUENCIAS

                dgvFrecuencia.Rows.Clear();

                foreach (var elemento in frecuencias.OrderBy(x => x.Key))
                {
                    dgvFrecuencia.Rows.Add(
                        elemento.Key.ToString("0.##"),
                        elemento.Value);
                }
            }
            catch
            {
                MessageBox.Show(
                    "Revise que los números estén escritos correctamente.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumeros.Clear();

            lblMedia.Text = "Media aritmética: -";
            lblMediana.Text = "Mediana: -";
            lblModa.Text = "Moda: -";
            lblVarianza.Text = "Varianza: -";
            lblDesviacionEstandar.Text =
                "Desviación estándar: -";
            lblDesviacionTipica.Text =
                "Desviación típica: -";
            lblRango.Text = "Rango: -";

            dgvFrecuencia.Rows.Clear();

            txtNumeros.Focus();
        }
    }
}