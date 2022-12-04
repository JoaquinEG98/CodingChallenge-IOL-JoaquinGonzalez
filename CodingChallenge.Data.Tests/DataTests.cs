using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes.Figuras;
using CodingChallenge.Data.Classes.Reportes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                new GeneradorReporte("Espaniol").Imprimir(new List<FormaGeometrica>()));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                new GeneradorReporte("English").Imprimir(new List<FormaGeometrica>()));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnFrances()
        {
            Assert.AreEqual("<h1>Liste de formes vide!</h1>",
                new GeneradorReporte("Français").Imprimir(new List<FormaGeometrica>()));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(5) };

            var resumen = new GeneradorReporte("Espaniol").Imprimir(cuadrados);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado (1),
                new Cuadrado(3)
            };

            var resumen = new GeneradorReporte("English").Imprimir(cuadrados);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadradosIdiomaInexistente()
        {
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(5) };

            var resumen = new GeneradorReporte("Portugues").Imprimir(cuadrados);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasRectangulos()
        {
            var rectangulos = new List<FormaGeometrica>
            {
                new Rectangulo(5, 2),
                new Rectangulo (3, 5),
                new Rectangulo(8, 3)
            };

            var resumen = new GeneradorReporte("English").Imprimir(rectangulos);

            Assert.AreEqual("<h1>Shapes report</h1>3 Rectangles | Area  49  | Perimeter  52 <br/>TOTAL:<br/>3 shapes Perimeter 52 Area 49", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTrapecios()
        {
            var trapecios = new List<FormaGeometrica>
            {
                new Trapecio(5, 3, 2, 4, 8, 2, 5),
                new Trapecio(8, 2, 3, 5, 6, 3, 4),
                new Trapecio(3, 2, 1, 5, 2, 6, 3),
            };

            var resumen = new GeneradorReporte("Français").Imprimir(trapecios);

            Assert.AreEqual("<h1>Rapport de formulaires</h1>3 Trapèzes | Aire  90  | Périmètre  43 <br/>TOTAL:<br/>3 Formes Périmètre 43 Aire 90", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(12.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = new GeneradorReporte("English").Imprimir(formas);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 538,98 | Perimeter 98,96 <br/>3 Triangles | Area  49,64  | Perimeter  51,6 <br/>TOTAL:<br/>7 shapes Perimeter 178,56 Area 617,62",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = new GeneradorReporte("Espaniol").Imprimir(formas);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 52,03 | Perimetro 36,13 <br/>3 Triángulo Equiláteros | Area  49,64  | Perimetro  51,6 <br/>TOTAL:<br/>7 formas Perimetro 115,73 Area 130,67",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnFrances()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m),
                new Trapecio(3, 2, 1, 5, 2, 6, 3),
            };

            var resumen = new GeneradorReporte("Français").Imprimir(formas);

            Assert.AreEqual(
                "<h1>Rapport de formulaires</h1>2 Carrés | Aire 29 | Périmètre 28 <br/>2 Cercles | Aire 52,03 | Périmètre 36,13 <br/>3 Triangles | Aire  49,64  | Périmètre  51,6 <br/>1 Trapèze | Aire  15  | Périmètre  11 <br/>TOTAL:<br/>8 Formes Périmètre 126,73 Aire 145,67",
                resumen);
        }
    }
}
