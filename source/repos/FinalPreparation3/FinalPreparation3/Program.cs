using System;
using System.IO;

namespace FinalPreparation3
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream fs = new FileStream();
            //StreamReader sr = new StreamReader(fs);
            //Console.WriteLine(fs.Name);

            string[] files = Directory.GetFiles(@"C:\Users\hafsamufassir\source\repos");
            for (int i = 0; i < files.Length; ++i)
            {
                string path = files[i];
                //Console.WriteLine(Path.GetFileName(path));
                string FileContents = File.ReadAllText(path);
                if (FileContents.Contains("KBTU"))
                {
                    Console.WriteLine(Path.GetFileName(path));
                }
            }
            Console.ReadKey();
        }
    }
}
