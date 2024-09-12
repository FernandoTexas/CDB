using Domain;

namespace Test
{
    public class CdbTests
    {
        [Fact]
        public async Task CalculaCDB()
        {            
            var cdb = new Cdb();
            double valorInicial = 1500;
            int meses = 24;
            double Cdipercentual = 0.09;
            double valorBruto = valorInicial;
            for (int i = 0; i < meses; i++)
            {
                valorBruto *= (1 + Cdipercentual);
            }
            double valorLiquido = valorBruto - (valorBruto * 0.15);
            
            var resultado = await cdb.CalculaCDB(valorInicial, meses);
            
            Assert.Equal(Math.Round(valorBruto, 2), resultado.ValorBruto);
            Assert.Equal(Math.Round(valorLiquido, 2), resultado.ValorLiquido);
        }
    }
}
