using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrimeNumbers
{

    class Program
    {

        static bool IsPrime(int n)//Функция, которая проверяет, простое ли число
        {
            if (n == 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(n); ++i)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            StreamReader file = new StreamReader(@"/Users/hafsamufassir/Documents/Primes.txt");
            string line = file.ReadToEnd();
            string[] arr = line.Split(' ');
            int min = 32891839;

            for (int i = 0; i < arr.Length; i++)
            {
               int x = int.Parse(arr[i]);

                if (IsPrime(x))
                {
                    if (min > x) min = x;
                }
            }

            //Console.WriteLine(min);
            //int minimum = min;
            string result = Convert.ToString(min);

            System.IO.File.WriteAllText(@"/Users/hafsamufassir/Documents/Result.txt", result);
            Console.ReadKey();//Режим ожидания
        }
    }

}