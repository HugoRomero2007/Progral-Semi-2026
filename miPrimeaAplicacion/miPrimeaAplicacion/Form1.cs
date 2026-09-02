using System;
using System.Windows.Forms;

namespace ConversorArea
{
    public partial class Form1 : Form
    {
        
        private readonly string[] opcionesArea = new string[]
        {
            "Pie Cuadrado",
            "Vara Cuadrada",
            "Yarda Cuadrada",
            "Metro Cuadrado",
            "Tareas",
            "Manzana",
            "Hectárea"
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }

        private void CargarCombos()
        {
            cmbDe.Items.AddRange(opcionesArea);
            cmbA.Items.AddRange(opcionesArea);

            cmbDe.SelectedIndex = 3;
            cmbA.SelectedIndex = 5;  
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtValor.Text, out double valor) && valor >= 0)
            {
                string unidadOrigen = cmbDe.SelectedItem.ToString();
                string unidadDestino = cmbA.SelectedItem.ToString();

               
                double metrosCuadrados = ConvertirAMetrosCuadrados(valor, unidadOrigen);

                
                double resultadoFinal = ConvertirDesdeMetrosCuadrados(metrosCuadrados, unidadDestino);

                lblResultado.Text = $"{valor:N2} {unidadOrigen} = {resultadoFinal:N4} {unidadDestino}";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido mayor o igual a 0.",
                                "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Focus();
            }
        }

        
        private double ConvertirAMetrosCuadrados(double valor, string unidad)
        {
            switch (unidad)
            {
                case "Pie Cuadrado":
                    return valor / 10.7639;
                case "Vara Cuadrada":
                    return valor / 1.4308;
                case "Yarda Cuadrada":
                    return valor / 1.19599;
                case "Metro Cuadrado":
                    return valor;
                case "Tareas":
                    return valor * 437.5; 
                case "Manzana":
                    return valor * 6988.96; 
                case "Hectárea":
                    return valor * 10000.0;
                default:
                    return 0;
            }
        }

        
        private double ConvertirDesdeMetrosCuadrados(double metros, string unidad)
        {
            switch (unidad)
            {
                case "Pie Cuadrado":
                    return metros * 10.7639;
                case "Vara Cuadrada":
                    return metros * 1.4308;
                case "Yarda Cuadrada":
                    return metros * 1.19599;
                case "Metro Cuadrado":
                    return metros;
                case "Tareas":
                    return metros / 437.5;
                case "Manzana":
                    return metros / 6988.96;
                case "Hectárea":
                    return metros / 10000.0;
                default:
                    return 0;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtValor.Clear();
            lblResultado.Text = "0.00 equivalente";
            cmbDe.SelectedIndex = 3;
            cmbA.SelectedIndex = 5;
            txtValor.Focus();
        }
    }
}