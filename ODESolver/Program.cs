using System.Numerics;

namespace ODESolver
{
    public class Program
    {
        public static void Main(string[] args)
        {
            float y = EulerMethod.ForwardEuler(0, 1, 0.00001f, 1, f);
            Console.WriteLine(y);
        }

        public static float f(float x, float y)
        {
            return y;
        }
    }
}
