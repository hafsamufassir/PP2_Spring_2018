using System;

namespace FinalPreparation1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int F = 1;
           for(int i = n; i > 1; i--)
            {
                F = i * F;
            }

            Console.WriteLine(F);
            Console.ReadKey();
        }
    }
}
