using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string line = Console.ReadLine();
            string[] arr = line.Split(' ');//Ввод чисел через пробел
            int ch;
            for (int i = 0; i < arr.Length; i++)//Пробегаемся по всем числам в строке
            {
                ch = int.Parse(arr[i]);//Вводим числа с клавиатуры

                if (IsPrime(ch))//Если число простое, вывести его
                {
                    Console.WriteLine(ch);
                }
            }

            Console.ReadKey();//Режим ожидания
        }
    }

}