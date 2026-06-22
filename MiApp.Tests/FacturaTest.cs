using System.Reflection;
using MiApp;
using Xunit;

namespace MiApp.Tests
{  

    public class FacturaTests
    {
        [Fact]
        public void Calculo_IVA_Factura()
        {
            var factura = new Factura(1, "ordenador", 1000);

            double resultado = factura.calcularIVA();

            Assert.Equal(1210, resultado);
        }

        [Fact]
        public void Factura_valor_valido_mayor_cero_test()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Factura(1, "ordenador", -1));
            Assert.Contains("Valor No Valido", ex.Message);
        }
    }
}