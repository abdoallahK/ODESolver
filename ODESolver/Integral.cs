namespace ODESolver
{
    public static class Integral
    {
        // Add Trapzoidal rule.

        /// <summary>
        /// Returns F(x) on [xstart, xend] using Riemann sum method.
        /// </summary>
        /// <param name="xstart">the initial x value.</param>
        /// <param name="xend">the final x value.</param>
        /// <param name="n">the number of steps.</param>
        /// <param name="f">the explicit function to be integrated.</param>
        /// <returns></returns>
        public static double RiemannSum(double xstart, double xend, double n, Functions.ExplicitFunction f)
        {
            double dx = (xend - xstart) / n;
            double x = xstart;
            double sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += dx * f(x);
                x += dx;
            }
            return sum;
        }
    }
}
