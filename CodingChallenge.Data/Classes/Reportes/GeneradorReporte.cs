using CodingChallenge.Data.Classes.Figuras;
using CodingChallenge.Data.Classes.Idioma;
using CodingChallenge.Data.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Reportes
{
    public class GeneradorReporte : Reporte
    {
        private readonly Traducciones _traducciones;

        public GeneradorReporte(string idioma)
        {
            _traducciones = new Traducciones(idioma);
        }

        public override string Imprimir(List<FormaGeometrica> formas)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append(_traducciones.ObtenerTraduccion("ListaVacia"));
            }
            else
            {
                sb.Append(_traducciones.ObtenerTraduccion("ReporteFormas"));

                ResultadoReporte resultado = CalcularFormas(formas);

                if (resultado.NumeroCuadrados > 0)
                    sb.Append($"{CalcularLinea("Cuadrado", resultado.NumeroCuadrados)} | {_traducciones.ObtenerTraduccion("Area")} {resultado.AreaCuadrados:#.##} | {_traducciones.ObtenerTraduccion("Perimetro")} {resultado.PerimetroCuadrados:#.##} <br/>");
                
                if (resultado.NumeroCirculos > 0) 
                    sb.Append($"{CalcularLinea("Circulo", resultado.NumeroCirculos)} | {_traducciones.ObtenerTraduccion("Area")} {resultado.AreaCirculos:#.##} | {_traducciones.ObtenerTraduccion("Perimetro")} {resultado.PerimetroCirculos:#.##} <br/>");
                
                if (resultado.NumeroTriangulos > 0)
                    sb.Append($"{CalcularLinea("TrianguloEquilatero", resultado.NumeroTriangulos)} | {_traducciones.ObtenerTraduccion("Area")}  {resultado.AreaTriangulos:#.##}  | {_traducciones.ObtenerTraduccion("Perimetro")}  {resultado.PerimetroTriangulos:#.##} <br/>");

                if (resultado.NumeroTrapecios > 0)               
                        sb.Append($"{CalcularLinea("Trapecio", resultado.NumeroTrapecios)} | {_traducciones.ObtenerTraduccion("Area")}  {resultado.AreaTrapecios:#.##}  | {_traducciones.ObtenerTraduccion("Perimetro")}  {resultado.PerimetroTrapecios:#.##} <br/>");

                if (resultado.NumeroRectangulos > 0)
                    sb.Append($"{CalcularLinea("Rectangulo", resultado.NumeroRectangulos)} | {_traducciones.ObtenerTraduccion("Area")}  {resultado.AreaRectangulos:#.##}  | {_traducciones.ObtenerTraduccion("Perimetro")}  {resultado.PerimetroRectangulos:#.##} <br/>");

                // FOOTER
                sb.Append(_traducciones.ObtenerTraduccion("Total"));
                sb.Append($"{resultado.TotalFormas} {_traducciones.ObtenerTraduccion("Formas")} ");
                sb.Append($"{_traducciones.ObtenerTraduccion("Perimetro")} {resultado.PerimetroTotal:#.##} ");
                sb.Append($"{_traducciones.ObtenerTraduccion("Area")} {resultado.AreaTotal:#.##}");
            }

            return sb.ToString();
        }

        private string CalcularLinea(string forma, int cantidad)
        {
            string nombre = $"{cantidad} {_traducciones.ObtenerTraduccion(forma)}";

            if (cantidad > 1)
            {
                nombre += "s"; // Agrego una 's' al final si hay mas de 1, para pasarlo a plural.
            }

            return nombre;
        }
    }
}
