using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Cdb : ICdb
    {
        public double Valor { get; set; }

        public double Meses { get; set; }
        public Cdb() { }
        public Cdb(double valor, double meses)
        {
            this.Valor = valor;
            this.Meses = meses;
        }

        public Task<ResultadoCdb> CalculaCDB(double valor, int meses)
        {            
            double ValorBruto = valor;

            for (int i = 0; i < meses; i++)
            {
                ValorBruto = ValorBruto * (1 + CdbPercentual.CalculaPercentualTbCdi());             
            }
            
           double Valorliquido = Imposto.Calcular(ValorBruto, meses);


            var resultadoCDB = new ResultadoCdb
            {
                ValorBruto = Math.Round(ValorBruto, 2),
                ValorLiquido = Math.Round(Valorliquido, 2)
            };
            
            return Task.FromResult(resultadoCDB);
        }                
    }
}
