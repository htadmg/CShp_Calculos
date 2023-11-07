using CShp_Calculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CShp_CalculosTest
{
    public class CalculoUnitTest
    {
        [Fact]
        public void Somar_DoisDouble_RetornaDouble()
        {
            // Arrange  
            var num1 = 2.9;
            var num2 = 3.1;
            var valorEsperado = 6;
            // Act  
            var soma = Calculo.Somar(num1, num2);
            //Assert  
            Assert.Equal(valorEsperado, soma);
        }
        [Fact]
        public void Subtrair_DoisDouble_RetornaDouble()
        {
            // Arrange  
            var num1 = 2.9;
            var num2 = 3.1;
            var valorEsperado = -0.2;
            // Act  
            var subtracao = Calculo.Subtrair(num1, num2);
            //Assert  
            Assert.Equal(valorEsperado, subtracao, 1);
        }
        [Fact]
        public void Multiplicar_DoisDouble_RetornaDouble()
        {
            // Arrange  
            var num1 = 2.9;
            var num2 = 3.1;
            var valorEsperado = 8.99;
            // Act  
            var mult = Calculo.Multiplicar(num1, num2);
            //Assert  
            Assert.Equal(valorEsperado, mult, 2);
        }
        [Fact]
        public void Dividir_DoisDouble_RetornaDouble()
        {
            // Arrange  
            var num1 = 2.9;
            var num2 = 3.1;
            var valorEsperado = 0.94; //Rounded value  
            // Act  
            var div = Calculo.Dividir(num1, num2);
            //Assert  
            Assert.Equal(valorEsperado, div, 2);
        }
    }
}
