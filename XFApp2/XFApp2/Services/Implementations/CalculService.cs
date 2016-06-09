using System;

namespace XFApp2.Services.Implementations
{
    public class CalculsService : ICalculsService
    {
        #region Calculs
        public double Addition(double n, double m)
        {
            return Math.Round(n + m, 2);
        }

        public double Division(double n, double m)
        {
            if (m != 0)
            {
                return Math.Round(n / m, 2);
            }
            throw new ArgumentException();
        }

        public double Multiplication(double n, double m)
        {
            return Math.Round(n * m, 2);
        }

        public double Substraction(double n, double m)
        {
            return Math.Round(n - m, 2);
        }
        #endregion

        #region Functions
        public int Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("N is under 0");
            }
            else if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        public int Fibonacci(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("N is under 0");
            }
            else if (n == 0)
            {
                return 0;
            }
            else if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        public double SquareRoot(double n)
        {
            return Math.Sqrt(n);
        }

        public double Square(double n)
        {
            return n * n;
        }

        public bool IsPrime(int n)
        {
            int boundary = (int)Math.Floor(Math.Sqrt(n));

            if (n < 1)
            {
                return false;
            }
            if (n == 2)
            {
                return true;
            }

            for (int i = 2; i <= boundary; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion
    }
}
