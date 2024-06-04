using desafio_final_trilha_net_tests.models;
using Xunit;

namespace Calculadora_Tests;

public class UnitTest1
{
    [Fact]
    public void Somar_DeveRetornarSomaCorreta()
    {
        // Arrange
        Calculadora calculadora = new Calculadora();

        // Act
        int resultado = calculadora.Somar(5, 3);

        // Assert
        Assert.Equal(8, resultado);
    }

    [Fact]
    public void Subtrair_DeveRetornarSubtracaoCorreta()
    {
        // Arrange
        Calculadora calculadora = new Calculadora();

        // Act
        int resultado = calculadora.Subtrair(10, 4);

        // Assert
        Assert.Equal(6, resultado);
    }

    [Fact]
    public void Multiplicar_DeveRetornarMultiplicacaoCorreta()
    {
        // Arrange
        Calculadora calculadora = new Calculadora();

        // Act
        int resultado = calculadora.Multiplicar(2, 3);

        // Assert
        Assert.Equal(6, resultado);
    }

    [Fact]
    public void Dividir_DeveRetornarDivisaoCorreta()
    {
        // Arrange
        Calculadora calculadora = new Calculadora();

        // Act
        int resultado = calculadora.Dividir(10, 2);

        // Assert
        Assert.Equal(5, resultado);
    }

    [Fact]
    public void Dividir_PorZero_DeveLancarExcecao()
    {
        // Arrange
        Calculadora calculadora = new Calculadora();

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => calculadora.Dividir(10, 0));
    }

    [Fact]
    public void Historico_DeveRetornarListaHistorico()
    {
        // Arrange
        Calculadora calculadora = new Calculadora();
        calculadora.Somar(2, 3);
        calculadora.Subtrair(5, 1);

        // Act
        var historico = calculadora.Historico();

        // Assert
        Assert.Equal(2, historico.Count);
        Assert.Contains("Soma de 2 e 3 = 5", historico);
        Assert.Contains("Subtração de 5 e 1 = 4", historico);
    }
}
