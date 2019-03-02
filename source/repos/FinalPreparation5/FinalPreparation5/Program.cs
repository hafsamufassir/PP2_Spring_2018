using System;

namespace FinalPreparation5
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double a = Math.Pow(2, n);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
