using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Trapecio : FormaGeometrica
    {
        public decimal LadoBaseA { get; }
        public decimal LadoBaseB { get; }
        public decimal LadoOblicuoC { get; }
        public decimal LadoOblicuoD { get; }
        public decimal Altura { get; }
        public Trapecio(decimal ladoBaseA, decimal ladoBaseB, decimal ladoOblicuoC, decimal ladoOblicuoD, decimal altura)
        {
            LadoBaseA = ladoBaseA;
            LadoBaseB = ladoBaseB;
            LadoOblicuoC = ladoOblicuoC;
            LadoOblicuoD = ladoOblicuoD;
            Altura = altura;
        }
        public override decimal Area => ((LadoBaseA + LadoBaseB) / 2) * Altura;

        public override decimal Perimetro => LadoBaseA + LadoBaseB + LadoOblicuoC + LadoOblicuoD;
    }
}
