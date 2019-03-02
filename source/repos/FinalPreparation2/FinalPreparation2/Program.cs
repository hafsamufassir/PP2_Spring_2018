using System;
using System.IO;

namespace FinalPreparation2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            //text = File.ReadAllText(@"C:\Users\hafsamufassir\source\repos\input.txt.txt");
            StreamReader file = new StreamReader(@"C:\Users\hafsamufassir\source\repos\input.txt.txt");
            text = file.ReadToEnd();

            int largest = int.MinValue;
            int second = int.MinValue;

            string[] arr = text.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                int x = int.Parse(arr[i]);
                if (x > largest)
                {
                    second = largest;
                    largest = x;
                }
                else if (x > second)
                {
                    second = x;
                }
                Console.Write(x + " ");
            }
            Console.WriteLine();
            Console.WriteLine(second);
            Console.ReadKey();
        }
    }
}