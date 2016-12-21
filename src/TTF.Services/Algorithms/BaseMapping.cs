using System;
using TTF.Services.Models;

namespace TTF.Services.Algorithms
{
    public class BaseMapping : MappingAlgorithm
    {
        public override Output Compute(Input input)
        {
            var x = ComputeX(input);
            return new Output
            {
                X = x,
                Y = ComputeY(x, input)
            };
        }        

        protected override X ComputeX(IInputX input)
        {
            return ComputeX(input.A, input.B, input.C);
        }

        protected override double ComputeY(X x, IInputY input)
        {
            return ComputeY(x, input.D, input.E, input.F);
        }

        public static X ComputeX(bool a, bool b, bool c)
        {
            if (b)
            {
                if (a && !c) return X.S;
                if (a && c) return X.R;
                if (!a && c) return X.T;
            }
            throw new InputException();
        }

        public static double ComputeY(X x, int d, int e, int f)
        {
            switch (x)
            {
                case X.S:
                    return d + (d * (double)e / 100);
                case X.R:
                    return d + (d * (double)(e - f) / 100);
                default:
                    return d - (d * (double)f / 100);
            }
        }
    }
}
