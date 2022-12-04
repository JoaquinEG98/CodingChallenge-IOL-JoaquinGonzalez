using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Figuras
{
    public class Rectangulo : FormaGeometrica
    {
        private readonly decimal _base;
        private readonly decimal _altura;

        public Rectangulo(decimal Base, decimal altura)
        {
            _base = Base;
            _altura = altura;
        }

        public override decimal CalcularArea()
        {
            return _base * _altura;
        }

        public override decimal CalcularPerimetro()
        {
            return _base * 2 + _altura * 2;
        }
    }
}
