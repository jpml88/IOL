using System;
using System.Threading;
using System.Globalization;

namespace CodingChallenge.Data.Classes
{
    public static class Idioma
    {
        public static void SetIdioma(int idiomaId)
        {
            switch (idiomaId)
            {
                //Español
                case 1:
                    //Thread.CurrentThread.CurrentUICulture = CultureInfo.DefaultThreadCurrentCulture;
                    break;
                //English
                case 2:
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
                    break;
                //Aleman
                case 3:
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("de-DE");
                    break;
                default:
                    throw new Exception();
            }
        }
    }
}
