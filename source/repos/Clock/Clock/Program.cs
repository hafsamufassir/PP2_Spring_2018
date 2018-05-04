using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clock
{
    class Program
    {
        static void Clock()
        {
            Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine(DateTime.Now);
            Thread.Sleep(100);
        }
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Black;
            int sec = 0;

            while (true)
            {
                Console.SetCursorPosition(0, 0);
                Clock();

                if (sec >= 12)
                {
                    sec = 0;
                }
                if (sec == 0 || sec == 12)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("      12");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("      12");
                }
                if (sec == 11)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("    11");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("    11");
                }
                if (sec == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("   1");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("   1");
                }
                if (sec == 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" 10");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" 10");
                }
                if (sec == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("        2");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("        2");
                }
                if (sec == 9)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("9");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("9");
                }
                if (sec == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("           3");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("           3");
                }
                if (sec == 8)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("  8");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("  8");
                }
                if (sec == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("       4");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("       4");
                }
                if (sec == 7)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("    7");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("    7");
                }
                if (sec == 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("   5");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("   5");
                }
                if (sec == 6)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("      6");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("      6");
                }
                sec++;
                Thread.Sleep(1000);

            }

        }
    }
}