using System;

namespace Vsite.CSharp
{
    // ispis tijeka izvođenja try-catch-finally bloka
    public class TijekIzvodjenja
    {
        public const string ZapočinjeBlokTry = "Blok try - početak";
        public const string ZavršavaBlokTry = "Blok try - kraj";
        public const string BlokCatch = "Blok catch";
        public const string BlokFinally = "Blok finally";

        public static void IspisTryCatchFinally(int djeljenjik, int djeljitelj)
        {
            // TODO: Donje naredbu umetnuti u try-blok te dodati catch blok za hvatanje iznimke u slučaju dijeljenja s 0 i finally blok. Dodati kontrolne ispise gornjih poruka u svaki od tih blokova te provjeriti što će se ispisati.
           try
            {
                Console.WriteLine(ZapočinjeBlokTry);
                Console.WriteLine("Dijelim s {0}", djeljitelj);
                Console.WriteLine(djeljenjik / djeljitelj);
                Console.WriteLine("Podijelio sam s {0}", djeljitelj);
                Console.WriteLine(ZavršavaBlokTry);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(BlokCatch);
            }
            finally
            {
                Console.WriteLine(BlokFinally);
            }
            

        }
        static void Main(string[] args)
        {
            int[] djeljitelji = new int[] { 1, 2, 0 };

            for (int i = 0; i < djeljitelji.Length; ++i)
            {
                IspisTryCatchFinally(3, djeljitelji[i]);

                Console.WriteLine();
            }

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
