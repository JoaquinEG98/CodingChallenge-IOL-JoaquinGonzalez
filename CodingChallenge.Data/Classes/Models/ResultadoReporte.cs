using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Models
{
    public class ResultadoReporte
    {
        public int TotalFormas { get; set; } = 0;

        public int NumeroCuadrados { get; set; } = 0;
        public int NumeroCirculos { get; set; } = 0;
        public int NumeroTriangulos { get; set; } = 0;
        public int NumeroTrapecios { get; set; } = 0;
        public int NumeroRectangulos { get; set; } = 0;

        public decimal AreaCuadrados { get; set; } = 0m;
        public decimal AreaCirculos { get; set; } = 0m;
        public decimal AreaTriangulos { get; set; } = 0m;
        public decimal AreaTrapecios { get; set; } = 0m;
        public decimal AreaRectangulos { get; set; } = 0m;

        public decimal PerimetroCuadrados { get; set; } = 0m;
        public decimal PerimetroCirculos { get; set; } = 0m;
        public decimal PerimetroTriangulos { get; set; } = 0m;
        public decimal PerimetroTrapecios { get; set; } = 0m;
        public decimal PerimetroRectangulos { get; set; } = 0m;

        public decimal AreaTotal { get; set; } = 0m;
        public decimal PerimetroTotal { get; set; } = 0m;
    }
}
