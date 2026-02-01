namespace ODESolver
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double forward = Derivative.ForwardDerivative(1, 0.00001, f);
            double backward = Derivative.BackwardDerivative(1, 0.00001, f);
            double firstCentral = Derivative.FirstOrderCentralDerivative(1, 0.00001, f);
            double secondCentral = Derivative.SecondOrderCentralDerivative(1, 0.00001, f);
            double riemann = Integral.RiemannSum(0, 1, 100000, f);
            double trapezoidal = Integral.TrapezoidalRule(0, 1, 100000, f);
            Console.WriteLine(forward);
            Console.WriteLine(backward);
            Console.WriteLine(firstCentral);
            Console.WriteLine(secondCentral);
            Console.WriteLine(riemann);
            Console.WriteLine(trapezoidal);
        }

        public static double f(double x)
        {
            return x * x;
        }
    }
}
