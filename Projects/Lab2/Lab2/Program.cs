using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void MaxMin()
        {
            //FileStream file = new FileStream(@"/Users/hafsamufassir/Documents/Numbers.txt", FileMode.Open,FileAccess.Read);
            string line;
            StreamReader file = new StreamReader(@"/Users/hafsamufassir/Documents/Numbers.txt");
            line = file.ReadToEnd();

            string[] arr = line.Split(' ');
            int min = 32891839;
            int max = -676381;
            for (int i = 0; i < arr.Length; i++)
            {
                int x = int.Parse(arr[i]);
                if (min > x) min = x;
                if (max < x) max = x;
            }
            Console.WriteLine("Max num = " + max);
            Console.WriteLine("Min num = " + min);
            Console.ReadKey();
            file.Close();
        }
        static void Main(string[] args)
        {
            MaxMin();
        }
    }
}
