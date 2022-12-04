using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Figuras
{
    public class Trapecio : FormaGeometrica
    {
        private readonly decimal _lado1;
        private readonly decimal _lado2;
        private readonly decimal _lado3;
        private readonly decimal _lado4;
        private readonly decimal _baseMayor;
        private readonly decimal _baseMenor;
        private readonly decimal _altura;

        public Trapecio(decimal lado1, decimal lado2, decimal lado3, decimal lado4, decimal baseMayor, decimal baseMenor, decimal altura)
        {
            _lado1 = lado1;
            _lado2 = lado2;
            _lado3 = lado3;
            _lado4 = lado4;
            _baseMayor = baseMayor;
            _baseMenor = baseMenor;
            _altura = altura;
        }

        public override decimal CalcularArea()
        {
            return (_baseMayor + _baseMenor / 2) * _altura;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado1 + _lado2 + _lado3 + _lado4;
        }
    }
}
