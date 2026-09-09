using System;
using System.Linq;

namespace miPrimeaAplicacion
{
    public class Estadistica
    {
        public double Media(double[] datos)
        {
            return datos.Average();
        }

        public double DesviacionTipica(double[] datos, double media)
        {
            return Math.Sqrt(Varianza(datos, media));
        }

        public double Armonica(double[] datos)
        {
            double sumaInversas = datos.Sum(n => 1.0 / n);
            return datos.Length / sumaInversas;
        }

        public double Varianza(double[] datos, double media)
        {
            double sumaCuadrados = datos.Sum(n => Math.Pow(n - media, 2));
            return sumaCuadrados / datos.Length;
        }
    }
}