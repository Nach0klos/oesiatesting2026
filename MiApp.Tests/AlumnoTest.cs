using System.Reflection;
using Xunit;
using MiApp;

namespace MiApp.Tests;

public class AlumnoTest
{
    [Fact]
    public void Alumno_No_Tiene_Notas()
    {
        // arrange preparar 
        var alumno = new Alumno(1, "pedro");
        Assert.Empty(alumno.Notas);
    }

    [Fact]
    public void Agregar_Nota_Alumno()
    {
        // arrange preparar 
        var alumno = new Alumno(1, "pedro");
        var nota = new Nota(5.5);

        // act ejecutar
        alumno.AgregarNota(nota);

        // assert validar
        Assert.Single(alumno.Notas);
        Assert.Contains(nota, alumno.Notas);
    }
}