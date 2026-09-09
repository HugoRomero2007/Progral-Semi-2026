using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace miPrimeaAplicacion
{
    public partial class Form1 : Form
    {
        // Instancia del objeto de la clase Estadistica
        private Estadistica objEsta = new Estadistica();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Limpiar();

            if (string.IsNullOrWhiteSpace(txtSerie.Text)) return;

            try
            {
                // Parseo de la serie de datos
                double[] miSerie = txtSerie.Text.Split(',')
                                               .Select(n => double.Parse(n.Trim()))
                                               .ToArray();

                // Llamadas a los métodos mediante el objeto objEsta
                double m = objEsta.Media(miSerie);

                ltsValores.Items.Add("La media es: " + m);
                ltsValores.Items.Add("La desviación típica: " + objEsta.DesviacionTipica(miSerie, m));
                ltsValores.Items.Add("La media armónica: " + objEsta.Armonica(miSerie));
                ltsValores.Items.Add("La varianza (desviación estándar): " + objEsta.Varianza(miSerie, m));
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa una serie válida de números separados por comas.",
                                "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            ltsValores.Items.Clear();
        }
    }
}