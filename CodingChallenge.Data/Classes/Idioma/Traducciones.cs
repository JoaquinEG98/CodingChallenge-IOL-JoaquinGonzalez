using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Idioma
{
    public class Traducciones
    {
        private readonly string _idioma;
        private Dictionary<string, Dictionary<string, string>> Diccionario { get; set; }

        public Traducciones(string idioma)
        {
            _idioma = idioma;

            Diccionario = new Dictionary<string, Dictionary<string, string>>
            {
                {
                    "Espaniol", // => Idioma Español, es el DEFAULT.
                    new Dictionary<string, string>
                    {
                        { "ListaVacia", "<h1>Lista vacía de formas!</h1>" },
                        { "ReporteFormas", "<h1>Reporte de Formas</h1>" },
                        { "Cuadrado", "Cuadrado" },
                        { "Circulo", "Círculo" },
                        { "TrianguloEquilatero", "Triángulo Equilátero" },
                        { "Trapecio", "Trapecio" },
                        { "Rectangulo", "Rectangulo" },
                        { "Formas", "formas" },
                        { "Total", "TOTAL:<br/>" },
                        { "Area", "Area" },
                        { "Perimetro", "Perimetro" },
                    }
                },
                {
                    "English",
                    new Dictionary<string, string>
                    {
                        { "ListaVacia", "<h1>Empty list of shapes!</h1>" },
                        { "ReporteFormas", "<h1>Shapes report</h1>" },
                        { "Cuadrado", "Square" },
                        { "Circulo", "Circle" },
                        { "TrianguloEquilatero", "Triangle" },
                        { "Trapecio", "Trapeze" },
                        { "Rectangulo", "Rectangle" },
                        { "Formas", "shapes" },
                        { "Total", "TOTAL:<br/>" },
                        { "Area", "Area" },
                        { "Perimetro", "Perimeter" },
                    }
                },
                {
                    "Français",
                    new Dictionary<string, string>
                    {
                        { "ListaVacia", "<h1>Liste de formes vide!</h1>" },
                        { "ReporteFormas", "<h1>Rapport de formulaires</h1>" },
                        { "Cuadrado", "Carré" },
                        { "Circulo", "Cercle" },
                        { "TrianguloEquilatero", "Triangle" },
                        { "Trapecio", "Trapèze" },
                        { "Rectangulo", "Rectangle" },
                        { "Formas", "Formes" },
                        { "Total", "TOTAL:<br/>" },
                        { "Area", "Aire" },
                        { "Perimetro", "Périmètre" },
                    }
                },
            };
        }

        public string ObtenerTraduccion(string traduccion)
        {
            if (Diccionario.ContainsKey(_idioma) && Diccionario[_idioma].ContainsKey(traduccion))
            {
                return Diccionario[_idioma][traduccion];
            }
            else
            {
                return Diccionario["Espaniol"][traduccion];
            }
        }
    }
}
