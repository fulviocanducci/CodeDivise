using System;
using CodeDivise.Models;

namespace CodeDivise
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal value = 200M;
            decimal input = 100M;
            int divise = 6;

            MathPortion mathPortion = new(value, divise, input);
            mathPortion.Run();

            foreach (decimal portion in mathPortion.Portions)
            {
                System.Console.WriteLine("Parcela: {0}", portion);
            }

            Console.WriteLine("\n\nDone ...");
        }
    }
}
