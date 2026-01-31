using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODESolver
{
    public static class EulerMethod
    {
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
        public static float ForwardEuler(float x0, float y0, float h, float target, Functions.ExplicitFunction f)
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
        public static float ForwardEuler(float x0, float y0, float h, float target, Functions.ImplicitFunction f)
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
