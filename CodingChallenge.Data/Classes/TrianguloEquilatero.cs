using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class TrianguloEquilatero : FormaGeometrica
    {
        public decimal Lado { get; }
        public TrianguloEquilatero(decimal ancho)
        {
            Lado = ancho;
        }
        public override decimal Area => ((decimal)Math.Sqrt(3) / 4) * Lado * Lado;

        public override decimal Perimetro => Lado * 3;
    }
}
