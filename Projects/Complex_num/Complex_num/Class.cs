using System;
namespace Complex_num
{
    public class Complex
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
}
