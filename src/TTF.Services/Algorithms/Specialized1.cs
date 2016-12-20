using System;
using TTF.Services.Models;

namespace TTF.Services.Algorithms
{
    public class Specialized1 : BaseMapping
    {
        protected override double ComputeY(X x, IInputY input)
        {
            return base.ComputeY(x, input);
        }

        public static new double ComputeY(X x, int d, int e, int f)
        {
            throw new NotImplementedException();
        }
    }
}
