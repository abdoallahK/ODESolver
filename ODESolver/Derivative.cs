namespace ODESolver
{
    public static class Derivative
    {
        // we approximate derivatives using Taylor expansion
        // dfdt approximatly equals f(t + h) - f(t) / h = dfdt + h * 0.5 * d2fdt2 + ...
        // This is Super weird

        /// <summary>
        /// Returns dy/dx at x = x0 for an explicit function using the forwards difference method.
        /// </summary>
        /// <param name="x0">The x value at which we want to find the derivative.</param>
        /// <param name="h">the step size (the smaller the better)</param>
        /// <param name="f">the explicit function</param>
        public static double ForwardDerivative(double x0, double h, Functions.ExplicitFunction f)
        {
            double fxh = f(x0 + h);
            double fx = f(x0);
            double change = fxh - fx;
            double  derivative = change / h;
            return derivative;
        }

        /// <summary>
        /// Returns dy/dx at x = x0 for an explicit function using the backwards difference method.
        /// </summary>
        /// <param name="x0">The x value at which we want to find the derivative.</param>
        /// <param name="h">the step size (the smaller the better)</param>
        /// <param name="f">the explicit function</param>
        public static double BackwardDerivative(double x0, double h, Functions.ExplicitFunction f)
        {
            double fxh = f(x0 - h);
            double fx = f(x0);
            double change = fx - fxh;
            double derivative = change / h;
            return derivative;
        }


        /// <summary>
        /// Returns dy/dx at x = x0 for an explicit function using the central difference method.
        /// </summary>
        /// <param name="x0">The x value at which we want to find the derivative.</param>
        /// <param name="h">the step size (the smaller the better)</param>
        /// <param name="f">the explicit function</param>
        public static double CentralDerivative(double x0, double h, Functions.ExplicitFunction f)
        {
            double addfxh = f(x0 + h);
            double subfxh = f(x0 - h);
            double change = addfxh - subfxh;
            double derivative = change / (2 * h);
            return derivative;
        }
    }
}
