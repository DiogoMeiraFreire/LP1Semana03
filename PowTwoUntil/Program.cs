using System;

namespace PowTwoUntil
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        private static void PowersOf2Until5()
        {
            for (int i = 0; i <= (1 << 5); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
