using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODESolver
{
    public static class DerivativeAndIntegral
    {
        //TODO: Add Riemann Sum and Trapozidal rule.

        /// <summary>
        /// Returns dy/dx at x = x0 for an explicit function
        /// </summary>
        /// <param name="x0">The x value at which we want to find the derivative.</param>
        /// <param name="h">the step size (the smaller the better)</param>
        /// <param name="f">the explicit function</param>
        public static float FindDerivative(float x0, float h, Functions.ExplicitFunction f)
        {
            float change = f(x0 + h) - f(h);
            float derivative = change / h;
            return derivative;
        }
    }
}
