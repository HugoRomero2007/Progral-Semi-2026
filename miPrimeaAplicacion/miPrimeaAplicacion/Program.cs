using System;
using System.Windows.Forms;

namespace ConversorArea
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Inicia directamente el formulario del Conversor de Área
            Application.Run(new Form1());
        }
    }
}