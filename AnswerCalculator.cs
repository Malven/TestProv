using System;

namespace Prov2015Test
{
    public class Calculator
    {
        public Calculator()
        {
        }

        public double Add(double v1, double v2)
        {
            return v1 + v2;
        }

        public double Mul(double v1, double v2)
        {
            return v1 * v2;
        }

        public double Div(double v1, double v2)
        {
            double sum = v1 / v2;
            if( double.IsInfinity(sum))
                throw new ArgumentException("Can't divide by zero");
            return sum;
        }

        public double Add(double[] numbers)
        {
            double sum = 0.0;
            foreach (double d in numbers)
                sum += d;
            return sum;
        }

        public bool IsPositive(double v)
        {
            if (v >= 0.0)
                return true;
            else
                return false;
        }

        public double Sum(string input)
        {
            char[] separators = { ',','\n'};
            string[] split = input.Split(separators);

            double sum = 0.0;

            foreach (string s in split)
            {
                double i = 0.0;

                if ( s != "")
                   i = double.Parse(s);
                
                if (i < 0)
                    throw new ArgumentException("Negative values not allowed");
                else if (i <= 1000.0)
                    sum += i;
            }
            return sum;
        }
    }
}