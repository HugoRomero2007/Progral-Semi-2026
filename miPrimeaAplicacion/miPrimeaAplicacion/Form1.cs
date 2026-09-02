using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImpuestoActividadesEconomicas
{
    public partial class Form1 : Form
    {
            
        private double[,] matrizTarifas = new double[,]
        {
            { 1, 0.01, 500.00, 1.50, 0.00 },
            { 2, 500.01, 1000.00, 1.50, 3.00 },
            { 3, 1000.01, 2000.00, 3.00, 3.00 },
            { 4, 2000.01, 3000.00, 6.00, 3.00 },
            { 5, 3000.01, 6000.00, 9.00, 2.00 },
            { 6, 8000.01, 18000.00, 15.00, 2.00 },
            { 7, 18000.01, 30000.00, 39.00, 2.00 },
            { 8, 30000.01, 60000.00, 63.00, 1.00 },
            { 9, 60000.01, 100000.00, 93.00, 0.80 },
            { 10, 100000.01, 200000.00, 125.00, 0.70 },
            { 11, 200000.01, 300000.00, 195.00, 0.60 },
            { 12, 300000.01, 400000.00, 255.00, 0.45 },
            { 13, 400000.01, 500000.00, 300.00, 0.40 },
            { 14, 500000.01, 1000000.00, 340.00, 0.30 },
            { 15, 1000000.01, 99999999.00, 490.00, 0.18 }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarTablaMatriz();
        }

        
        private void CargarTablaMatriz()
        {
            dgvTablaImpuestos.Rows.Clear();
            int filas = matrizTarifas.GetLength(0);

            for (int i = 0; i < filas; i++)
            {
                dgvTablaImpuestos.Rows.Add(
                    matrizTarifas[i, 0],
                    matrizTarifas[i, 1].ToString("N2"),
                    matrizTarifas[i, 2].ToString("N2"),
                    "$" + matrizTarifas[i, 3].ToString("F2"),
                    "$" + matrizTarifas[i, 4].ToString("F2")
                );
            }
        }

        
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtMonto.Text, out double monto) && monto > 0)
            {
                CalcularImpuesto(monto);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un monto válido mayor a 0 en USD ($).",
                                "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMonto.Focus();
            }
        }

        
        private void CalcularImpuesto(double monto)
        {
            int filas = matrizTarifas.GetLength(0);
            bool encontrado = false;

            for (int i = 0; i < filas; i++)
            {
                double desde = matrizTarifas[i, 1];
                double hasta = matrizTarifas[i, 2];
                double precioFijo = matrizTarifas[i, 3];
                double adicional = matrizTarifas[i, 4];

                if (monto >= desde && monto <= hasta)
                {
                    encontrado = true;

                    
                    
                    double diferencia = monto - desde;
                    double impuesto = (diferencia / 1000.0) * adicional + precioFijo;

                    
                    lblResultadoRango.Text = $"Tramo N° {matrizTarifas[i, 0]}: Rango de ${desde:N2} a ${hasta:N2}";
                    lblResultadoImpuesto.Text = $"Valor a pagar: ${impuesto:N2}";

                    
                    ResaltarFilaGrid(i);
                    break;
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("El monto ingresado está fuera de los rangos establecidos.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
        private void ResaltarFilaGrid(int indiceFila)
        {
            foreach (DataGridViewRow row in dgvTablaImpuestos.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }

            dgvTablaImpuestos.Rows[indiceFila].DefaultCellStyle.BackColor = Color.LightGreen;
        }

        
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMonto.Clear();
            lblResultadoRango.Text = "Tramo aplicado: N/A";
            lblResultadoImpuesto.Text = "Valor a pagar: $0.00";

            foreach (DataGridViewRow row in dgvTablaImpuestos.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }

            txtMonto.Focus();
        }
    }
}