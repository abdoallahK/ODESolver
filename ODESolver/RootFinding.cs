using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODESolver
{
    public static class RootFinding
    {
        //ToDo : Look up how to numerically find roots.
        public static double NewtownsMethod(double intial, double tol, double h, Functions.ExplicitFunction f)
        {
            double x1 = intial, x2 = 0;
            do
            {
                x2 = x1 - f(x1) / Derivative.FirstOrderCentralDerivative(x1, h, f);
                if (Math.Abs(x2 - x1) < tol)
                {
                    return x2;
                }
                x1 = x2;
            }
            while (true);
        }
    }
}
