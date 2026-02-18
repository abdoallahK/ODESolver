namespace ODESolver
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double newton = RootFinding.NewtownsMethod(4, 0.00001, 0.00001, froot);
            Console.WriteLine(newton);
        }

        public static double f(double x)
        {
            return x * x;
        }

        public static double froot(double x)
        {
            return x * x - 4;
        }
    }
}
