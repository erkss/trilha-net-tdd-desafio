using Calculadora.Services;

namespace CalculadoraTests;

public class CalculadoraTests
{
    public CalculadoraImp construirClasse()
    {
        CalculadoraImp calc = new CalculadoraImp("04/11/2023");
        return calc;
    }

    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (4, 5, 9)]
    public void TestSomar(int val1, int val2, int resultado)
    {
        // Arrange
        CalculadoraImp calc = construirClasse();

        // Act
        int resultadoCalculadora = calc.somar(val1, val2);

        // Assert 
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (6, 2, 4)]
    [InlineData (10, 5, 5)]
    public void TestSubtrair(int val1, int val2, int resultado)
    {
        // Arrange
        CalculadoraImp calc = construirClasse();

        // Act
        int resultadoCalculadora = calc.subtrair(val1, val2);

        // Assert 
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (1, 2, 2)]
    [InlineData (4, 5, 20)]
    public void TestMultiplicar(int val1, int val2, int resultado)
    {
        // Arrange
        CalculadoraImp calc = construirClasse();

        // Act
        int resultadoCalculadora = calc.multiplicar(val1, val2);

        // Assert 
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (6, 2, 3)]
    [InlineData (5, 5, 1)]
    public void TestDividir(int val1, int val2, int resultado)
    {
        // Arrange
        CalculadoraImp calc = construirClasse();

        // Act
        int resultadoCalculadora = calc.dividir(val1, val2);

        // Assert 
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        // Arrange
        CalculadoraImp calc = construirClasse();

        // Assert
        Assert.Throws<DivideByZeroException>(
            () => calc.dividir(3,0)
        );
    }

    [Fact]
    public void TestarHistorico()
    {
        // Arrange
        CalculadoraImp calc = construirClasse();

        // Act
        calc.somar(1, 2);
        calc.somar(2, 8);
        calc.somar(3, 7);
        calc.somar(4, 1);
        var lista = calc.historico();

        // Assert
        Assert.NotEmpty(calc.historico());
        Assert.Equal(3, lista.Count);
    }
}