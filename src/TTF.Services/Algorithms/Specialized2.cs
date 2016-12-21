using System;
using TTF.Services.Models;

namespace TTF.Services.Algorithms
{
    public class Specialized2 : BaseMapping
    {
        public static new X ComputeX(bool a, bool b, bool c)
        {
            if (a && b && !c)
                return X.T;
            if (a && !b && c)
                return X.S;
            return BaseMapping.ComputeX(a, b, c);
        }

        public static new double ComputeY(X x, int d, int e, int f)
        {
            if (x == X.S)
                return f + d + ((double)d * e / 100); // Also F + BaseMapping.ComputeY(x, d, e, f)
            return BaseMapping.ComputeY(x, d, e, f);
        }
    }
}
