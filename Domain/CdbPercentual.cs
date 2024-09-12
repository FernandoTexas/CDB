using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public static class CdbPercentual
    {
        private static readonly double TB = 1.08;
        private static readonly double CDI = 0.009;

        public static double CalculaPercentualTbCdi()
        {
            return TB * CDI;
        }
    }
}
