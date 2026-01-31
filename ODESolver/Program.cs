using System.Numerics;

namespace ODESolver
{
    public class Program
    {
        public static void Main(string[] args)
        {
            float y = ODESolver.ForwardEulerImplicitFunction(0, 1, 0.00001f, 1, f);
            Console.WriteLine(y);
        }

        public static float f(float x, float y)
        {
            return y;
        }
    }

    public class ODESolver
    {
        /// <summary>
        /// Define an implicit function.
        /// </summary>
        public delegate float ImplicitFunction(float x, float y);

        /// <summary>
        /// Define an explicit function.
        /// </summary>
        public delegate float ExplicitFunction(float x);

        /// <summary>
        /// The forward Euler method for explicit functions which follows the following algorithm:
        /// f(x) = dy/dx 
        /// xn+1 = xn + h; 
        /// yn+1 = yn + h * f(x); 
        /// </summary>
        /// <param name="x0">the initial x value</param>
        /// <param name="y0">the initial y value</param>
        /// <param name="h">the step size</param>
        /// <param name="target">the final x value</param>
        /// <param name="f">the explicit slope function</param>
        /// <returns>the final y value</returns>
        public static float ForwardEulerExplicitFunction(float x0, float y0, float h, float target,  ExplicitFunction f)
        {
            float x = x0;
            float y = y0;
            for (int i = 0; i < target / h; i++)
            {
                x += h;
                y += h * f(x);
            }
            return y;
        }

        /// <summary>
        /// the forward Euler method for implicit functions which uses the following algorithm:
        /// f(x, y) = dy/dx
        /// xn+1 = xn + h;
        /// yn+1 = yn + h * f(x, y);
        /// </summary>
        /// <param name="x0">the initial x value</param>
        /// <param name="y0">the intial y value</param>
        /// <param name="h">the step size</param>
        /// <param name="target">the fian x value</param>
        /// <param name="f">the implicit slope function</param>
        /// <returns>the final y value</returns>
        public static float ForwardEulerImplicitFunction(float x0, float y0, float h, float target, ImplicitFunction f)
        {
            float x = x0;
            float y = y0;
            for (int i = 0; i < target / h; i++)
            {
                x += h;
                y += h * f(x, y);
            }
            return y;
        }
    }
}
