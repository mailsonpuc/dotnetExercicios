using app.Models;
using Xunit;

namespace app.test;

public class CalculadoraTests
{
    private Calculadora _calc;

    public CalculadoraTests()
    {
        _calc = new Calculadora();
        
    }



    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
         //Arrange
        int num1 = 5;
        int num2 = 10;

        //Act
        int resultado = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(15, resultado);
    }



    [Fact]
    public void DeverMultiplicar5Com5Eretornar25()
    {
        //Arrange
        int num1 = 5;
        int num2 = 5;

        //Act
        int resultado = _calc.Multiplicar(num1, num2);

        //Assert
        Assert.Equal(25, resultado);
    }
}