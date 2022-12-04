using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Figuras
{
    public class Circulo : FormaGeometrica
    {
        private readonly decimal _lado;

        public Circulo(decimal lado)
        {
            _lado = lado;
        }

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (_lado * _lado);
        }

        public override decimal CalcularPerimetro()
        {
            return 2 * (decimal)Math.PI * _lado;
        }
    }
}
