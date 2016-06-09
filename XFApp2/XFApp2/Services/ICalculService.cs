namespace XFApp2.Services
{
    public interface ICalculsService
    {
        double Addition(double n, double m);
        double Division(double n, double m);
        double Multiplication(double n, double m);
        double Substraction(double n, double m);

        int Factorial(int n);
        int Fibonacci(int n);
        double SquareRoot(double n);
        double Square(double n);
        bool IsPrime(int n);
    }
}
