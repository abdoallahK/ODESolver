using System.Numerics;

namespace ODESolver
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double forward = Derivative.ForwardDerivative(1, 0.00001, f);
            double backward = Derivative.BackwardDerivative(1, 0.00001, f);
            double central = Derivative.CentralDerivative(1, 0.00001, f);
            Console.WriteLine(forward);
            Console.WriteLine(backward);
            Console.WriteLine(central);
        }

        public static double f(double x)
        {
            return x * x;
        }
    }
}
