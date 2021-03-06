﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_numbers
{
    class Complex
    {
        int a, b;
        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public static Complex operator +(Complex x, Complex y)
        {
            return new Complex(x.a + y.a, x.b + y.b);
        }
        public override string ToString()
        {
            return this.a + "," + b;
        }

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

           

            Console.WriteLine(c1+c2);
            Console.ReadKey();
        }
    }
}