using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : FormaGeometrica
    {
        public decimal Lado { get; }
        public Cuadrado(decimal ancho)
        {
            Lado = ancho;
        }
        public override decimal Area => Lado * Lado;

        public override decimal Perimetro => Lado * 4;
    }
}
