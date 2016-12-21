using System;
using TTF.Services.Models;

namespace TTF.Services.Algorithms
{
    public class Specialized1 : BaseMapping
    {
        public static new double ComputeY(X x, int d, int e, int f)
        {
            if (x == X.R)
                return 2 * d + ((double)d * e / 100);
            return BaseMapping.ComputeY(x, d, e, f);
        }

        protected override double ComputeY(X x, IInputY input)
        {
            return ComputeY(x, input.D, input.E, input.F);
        }
    }
}
