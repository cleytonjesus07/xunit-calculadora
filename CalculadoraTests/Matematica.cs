using Calculadora.Models;

namespace CalculadoraTests;

public class MatematicaTest
{
    
    [Theory]
    [InlineData(1,2)]
    [InlineData(10,20)]
    public void DeveSomarDoisNumerosERetornarOResultado(int num1,int num2)
    {
        Matematica _matematica = new(num1,num2);
        int resultado = _matematica.Somar();
        Assert.Equal(num1 + num2, resultado);
    }
   
    [Theory]
    [InlineData(4,4)]
    [InlineData(30,40)]
    public void DeveSubtrairDoisNumerosERetornarOResultado(int num1,int num2)
    {
        Matematica _matematica = new(num1,num2);
        int resultado = _matematica.Subtrair();
        Assert.Equal(num1 - num2, resultado);
    }

    [Theory]
    [InlineData(100,2)]
    [InlineData(3,20)]
    public void DeveMultiplicarDoisNumerosERetornarOResultado(int num1,int num2)
    {
        Matematica _matematica = new(num1,num2);
        int resultado = _matematica.Multiplicar();
        Assert.Equal(num1 * num2, resultado);
    }

    [Theory]
    [InlineData(34,233)]
    [InlineData(1035,250)]
    public void DeveDividirDoisNumerosERetornarOResultado(int num1,int num2)
    {
        Matematica _matematica = new(num1,num2);
        int resultado = _matematica.Dividir();
        Assert.Equal(num1 / num2, resultado);
    }


    /* Cenário negativo */
   
    [Theory]
    [InlineData(10,0)]
    [InlineData(400,0)]
    public void DeveTentarDividirPorZeroERetornarUmaExcecao(int num1,int num2)
    {
        Matematica _matematica = new(num1,num2);
        int resultado = _matematica.Dividir();
        Assert.Throws<DivideByZeroException>(()=> num1 / num2);
    }

}