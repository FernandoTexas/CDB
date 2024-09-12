using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public static class Imposto
    {
        private static readonly double Faixa1 = 22.5;
        private static readonly double Faixa2 = 20.5;
        private static readonly double Faixa3 = 17.5;
        private static readonly double Faixa4 = 15.0;

        public static double Calcular(double valor, int meses)
        {
            double taxa;

            if (meses >= 1 && meses <= 6)
            {
                taxa = Faixa1;
            }
            else if (meses > 6 && meses <= 12)
            {
                taxa = Faixa2;
            }
            else if (meses > 12 && meses <= 24)
            {
                taxa = Faixa3;
            }
            else
            {
                taxa = Faixa4;
            }

            return valor - (valor * taxa / 100);
        }
    }
}
