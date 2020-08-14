using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Circulo : FormaGeometrica
    {
        public decimal Lado { get; }
        public Circulo(decimal ancho)
        {
            Lado = ancho;
        }
        public override decimal Area => (decimal)Math.PI * (Lado / 2) * (Lado / 2);

        public override decimal Perimetro => (decimal)Math.PI * Lado;
    }
}
