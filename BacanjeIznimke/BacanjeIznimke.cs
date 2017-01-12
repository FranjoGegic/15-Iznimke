using System;

namespace Vsite.CSharp
{
    public static class Math
    {
        public static int Faktorjel(int broj)
        {
            // TODO: Dodati u metodu provjeru je li argument manji od 0 i u tom slučaju baciti iznimku tipa ArgumentOutOfRangeException s odogovarajućom porukom
            if (broj < 0)
                throw new ArgumentOutOfRangeException(nameof(broj), "Argument ne smije biti manji od nule");
            try
            {
                int rezultat = 1;
                for (int i = 2; i <= broj; ++i)
                    rezultat *= i;
                return rezultat;
            }
            catch (OverflowException e)
            {
                throw new ArgumentOutOfRangeException(nameof(broj),broj, "Argument je prevelik");
            }            
        }

        public static int Povrh(int n, int k)
        {
            return Faktorjel(n) / (Faktorjel(k) * Faktorjel(n - k));
        }
    }

    public class BacanjeIznimke
    {
        static void Main(string[] args)
        {
            // TODO: Provjeriti vraćaju li donji pozivi metode očekivane rezultate
            try
            { 
                int n = 0;
                Console.WriteLine("{0}! = {1}", n, Math.Faktorjel(n)); // trebalo bi biti 0! = 1
                n = 3;
                Console.WriteLine("{0}! = {1}", n, Math.Faktorjel(n)); // trebalo bi biti 3! = 6
                n = 5;
                Console.WriteLine("{0}! = {1}", n, Math.Faktorjel(n)); // trebalo bi biti 5! = 120

                n = -1;
                Console.WriteLine("{0}! = {1}", n, Math.Faktorjel(n)); // trebalo bi baciti iznimku!
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e);
            }


            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
