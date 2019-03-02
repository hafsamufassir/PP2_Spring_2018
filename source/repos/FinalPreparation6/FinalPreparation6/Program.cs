using System;
using System.IO;

namespace FinalPreparation6
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader(@"C:\Users\hafsamufassir\source\repos\input.txt.txt");
            string line = file.ReadToEnd();
            string[] arr = line.Split(' ');

            int smallest = int.MaxValue;
            int secondMin = int.MaxValue;

            for(int i = 0; i < arr.Length; i++)
            {
                int x = int.Parse(arr[i]);
                if (x < smallest)
                {
                    secondMin = smallest;
                    smallest = x;
                }
                else if (x < secondMin)
                {
                    secondMin = x;
                }

            }
            Console.WriteLine(secondMin);
            Console.ReadKey();
        }
    }
}
