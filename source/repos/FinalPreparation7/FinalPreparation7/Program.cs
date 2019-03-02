using System;
using System.IO;

namespace FinalPreparation7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles(@"C:\Users\hafsamufassir\source\repos");
            for(int i = 0; i < files.Length; i++)
            {
                string file = files[i];
                string fileContents = File.ReadAllText(file);
                if (fileContents.Contains("FIT"))
                {
                    Console.WriteLine(Path.GetFileName(file));
                }
            }
            Console.ReadKey();
        }
    }
}
