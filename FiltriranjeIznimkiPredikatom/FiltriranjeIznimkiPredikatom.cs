using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp
{
    public class FiltriranjeIznimkiPredikatom
    {
        public static class Math
        {
            public static double Logaritam(double broj, double baza)
            {
                if (broj < 0)
                    throw new ArgumentOutOfRangeException(nameof(broj), broj, "Broj mora biti veći ili jednak 0.");
                if (baza <= 0)
                    throw new ArgumentOutOfRangeException(nameof(baza), baza, "Baza mora biti veća od 0.");
                return System.Math.Log(broj, baza);
            }
        }


        public const string NedozvoljeniBroj = "Nedozvoljeni broj";
        public const string NedozvoljenaBaza = "Nedozvoljena baza";

        public const string FormatIspisa = "Logaritam broja {0} po bazi {1} = {2}";

        public static void IspišiLogaritamBroja(double broj, double baza)
        {
            // TODO: Proširiti blok hvatanja filterom koji će provjeravati koji je argument neispravan te ispisati jednu od gornje dvije poruke.
            try
            {
                Console.WriteLine(FormatIspisa, broj, baza, Math.Logaritam(broj, baza));
            }
            catch (ArgumentOutOfRangeException e)  when (e.ParamName=="broj")
            {
                Console.WriteLine(NedozvoljeniBroj);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine(NedozvoljenaBaza);
            }
        }

        static void Main(string[] args)
        {
            IspišiLogaritamBroja(100, 10);
            IspišiLogaritamBroja(-100, 10);
            IspišiLogaritamBroja(100, -10);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
