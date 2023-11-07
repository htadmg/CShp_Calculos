using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShp_Calculos
{
    public static class Calculo
    {
        public static double Somar(double numero1, double numero2)
        {
            return (numero1 + numero2);
        }
        public static double Subtrair(double numero1, double numero2)
        {
            return (numero1 - numero2);
        }
        public static double Multiplicar(double numero1, double numero2)
        {
            return (numero1 * numero2);
        }
        public static double Dividir(double numero1, double numero2)
        {
            return (numero1 / numero2);
        }
        public static bool IsNumeroPar(int numero)
        {
            return numero % 2 == 0;
        }

        public static object Somar(double v)
        {
            throw new NotImplementedException();
        }
    }
}
