using System.Reflection;
using Xunit;
using MiApp;

// Repeatable, Isolated, Self-validating, Timely (RIST)

namespace MiApp.Tests

{

public class NotaTest

{
    [Fact]
    public void Nota_Suspensa_Test()

    {
        // Arrange

        var nota = new Nota(4.9);

        // Act

        var calificacion = nota.ObtenerCalificacion();

        // Assert

        Assert.Equal("Suspenso", calificacion);

    }

    [Fact]
    public void Nota_Aprobada_Test()
    {
        // Arrange

        var nota = new Nota(5.5);

        // Act

        var calificacion = nota.ObtenerCalificacion();

        // Assert

        Assert.Equal("Aprobado", calificacion);

    }
    
    [Fact]
    public void Nota_Notable_Test()
    {

        // Arrange

        var nota = new Nota(9);

        // Act

        var calificacion = nota.ObtenerCalificacion();

        // Assert

        Assert.Equal("Notable", calificacion);

    }

    [Fact]

    public void Nota_Sobresaliente_Test()
    {

        // Arrange

        var nota = new Nota(9.5);

        // Act

        var calificacion = nota.ObtenerCalificacion();

        // Assert

        Assert.Equal("Sobresaliente", calificacion);

    }

    [Fact]
    public void Nota_Mayor_10_Test()
    {
        // Act & Assert

        var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new Nota(11));

        Assert.Contains("El valor debe estar entre 0 y 10", ex.Message);

    }

    [Theory]
    [InlineData(0, "Suspenso")]
    [InlineData(4.9, "Suspenso")]
    [InlineData(5, "Aprobado")]
    [InlineData(6, "Aprobado")]
    [InlineData(6.5, "Bien")]
    [InlineData(7, "Bien")]
    [InlineData(7.5, "Notable")]
    [InlineData(9, "Notable")]
    [InlineData(9.5, "Sobresaliente")]
    [InlineData(10, "Sobresaliente")]
    public void Nota_ObtenerCalificacion_Test(double valor, string calificacionEsperada)
    {
        // Arrange
        var nota = new Nota(valor);

        // Act
        var calificacion = nota.ObtenerCalificacion();

        // Assert
        Assert.Equal(calificacionEsperada, calificacion);
    }

    [Fact]
    public void Nota_Igualdad_Test()
    {      

        Nota nota1= new Nota(5);
        Nota nota2 = new Nota(5);
 
        Assert.Equal(nota1,nota2);
    }

    [Fact]
    public void Nota_No_Igualdad_Test()
    {
        Nota nota1= new Nota(5);
        Nota nota2 = new Nota(6);

        Assert.NotEqual(nota1,nota2);
    }

    [Fact]
    public void Nota_HashCode_Test()
    {
        Nota nota1= new Nota(5);
        Nota nota2 = new Nota(5);

        int numero1=nota1.GetHashCode();
        int numero2=nota2.GetHashCode();

        Assert.Equal(numero1,numero2);
    }

}

}