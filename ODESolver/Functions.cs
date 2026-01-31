using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODESolver
{
    public static class Functions
    {
        /// <summary>
        /// Define an implicit function.
        /// </summary>
        public delegate float ImplicitFunction(float x, float y);

        /// <summary>
        /// Define an explicit function.
        /// </summary>
        public delegate float ExplicitFunction(float x);

    }
}
