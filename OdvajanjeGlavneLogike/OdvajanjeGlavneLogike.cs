using System;

namespace Vsite.CSharp
{
    public class OdvajanjeGlavneLogike
    {
        public static void IspisPovrh(int prvi, int zadnji)
        {
            // TODO: Donje petlje obuhvatiti try-catch blokom koji će prekinuti daljnje računanje kada bude bačena iznimka. Unutar bloka hvatanja ispisati poruku o pogrešci.
            try
            {
                for (int n = prvi; n < zadnji; ++n)
                {
                    for (int k = 1; k <= n; ++k)
                    {
                        Console.WriteLine("{0} povrh {1} = {2}", n, k, Math.Povrh(n, k));
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static void Main(string[] args)
        {
            IspisPovrh(1, 20);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
