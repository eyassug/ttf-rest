using System;
using TTF.Services.Models;

namespace TTF.Services.Algorithms
{
    public class Specialized2 : BaseMapping
    {
        protected override X ComputeX(IInputX input)
        {
            return base.ComputeX(input);
        }

        protected override double ComputeY(X x, IInputY input)
        {
            return base.ComputeY(x, input);
        }

        public static new X ComputeX(bool a, bool b, bool c)
        {
            throw new NotImplementedException();
        }

        public static new double ComputeY(X x, int d, int e, int f)
        {
            throw new NotImplementedException();
        }
    }
}
