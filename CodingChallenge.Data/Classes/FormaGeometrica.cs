/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public abstract class FormaGeometrica
    {
        public override string ToString() => GetType().Name;
        public abstract decimal Area { get; }
        public abstract decimal Perimetro { get; }
        public static string Imprimir(List<FormaGeometrica> figuras, int idioma)
        {
            Idioma.SetIdioma(idioma);
            var sb = new StringBuilder();
            if (!figuras.Any())
            {
                sb.Append(Strings.SinFiguras);
            }
            else
            {
                var figura_total = figuras.GroupBy(a => a.GetType().Name).Select(ab => new Resultado
                {
                    figura = ab.Key,
                    cantidad = ab.Count(),
                    perimetro = ab.Sum(a => a.Perimetro),
                    area = ab.Sum(a => a.Area)
                });
                // HEADER
                sb.Append(Strings.Titulo);
                //Shapes report
                foreach (Resultado _row in figura_total)
                {
                    sb.Append(_row.cantidad + " "
                        + Obtener_Plural(_row.cantidad, _row.figura)
                        + " | "
                        + Strings.Area + " " + String.Format("{0:0.##}", _row.area) + " | "
                        + Strings.Perimetro + " " + String.Format("{0:0.##}", _row.perimetro)
                        + " <br/>");
                }
                //// FOOTER
                sb.Append(Strings.TituloResultado);
                var figuras_totales = figuras.GroupBy(a => "Totales").Select(ab => new Resultado_Total
                {
                    cantidad = ab.Count(),
                    perimetro = ab.Sum(a => a.Perimetro),
                    area = ab.Sum(a => a.Area)
                });
                foreach (Resultado_Total _row in figuras_totales)
                {
                    sb.Append(_row.cantidad + " " + Strings.Figuras + " "
                    + Strings.Perimetro + " " + String.Format("{0:0.##}", _row.perimetro) + " "
                    + Strings.Area + " " + String.Format("{0:0.##}", _row.area));
                }
            }
            Console.WriteLine(sb.ToString());
            return sb.ToString();
        }
        private static string Obtener_Plural(int cantidad, string figura)
        {
            if (cantidad == 1)
            {
                return Strings.ResourceManager.GetString(figura);
            }
            else
            {
                return Strings.ResourceManager.GetString(figura + "_Plural");
            }
        }
        private class Resultado
        {
            public string figura;
            public int cantidad;
            public decimal area;
            public decimal perimetro;
        }
        private class Resultado_Total
        {
            public int cantidad;
            public decimal area;
            public decimal perimetro;
        }
    }
}
