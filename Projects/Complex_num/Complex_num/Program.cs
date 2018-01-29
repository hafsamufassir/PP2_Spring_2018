using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_numbers
{
    class Complex
    {
        int a;
        int b;
    }
    class Program
    {
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine();
            string[] arr1 = line1.Split(' ');

            int a = int.Parse(arr1[0]);
            int b = int.Parse(arr1[1]);

            string line2 = Console.ReadLine();
            string[] arr2 = line2.Split(' ');

            int c = int.Parse(arr2[0]);
            int d = int.Parse(arr2[1]);

            Complex c1 = new Complex(a, b);
            Complex c2 = new Complex(c, d);

            Complex summ = c1 + c2;
            Complex diff = c1 - c2;
            Complex prod = c1 * c2;
            Complex div = c1 / c2;

            Console.WriteLine("Summ of complex numbers is equal to " + summ);
            Console.WriteLine("Difference of complex numbers is equal to " + diff);
            Console.WriteLine("Product of complex numbers is equal to " + prod);
            Console.WriteLine("Quotient of complex numbers is equal to " + d);

            Console.ReadKey();
        }
    }
}
