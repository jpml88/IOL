using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : FormaGeometrica
    {
        public decimal Lado { get; }
        public Rectangulo(decimal ancho)
        {
            Lado = ancho;
        }
        public override decimal Area => (Lado * 2) + (Lado * 2);

        public override decimal Perimetro => Lado * 4;
    }
}
