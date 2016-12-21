using Microsoft.VisualStudio.TestTools.UnitTesting;
using TTF.Services.Algorithms;
using TTF.Services.Models;

namespace TTF.Services.Tests.Algorithms
{
    [TestClass]
    public class BaseMappingTests
    {
        [TestMethod]
        public void ComputeX_ShouldReturnCorrectXValues()
        {
            var s = new bool[] { true, true, false };
            var r = new bool[] { true, true, true };
            var t = new bool[] { false, true, true };

            var xs = BaseMapping.ComputeX(s[0],s[1], s[2]);
            var xr = BaseMapping.ComputeX(r[0], r[1], r[2]);
            var xt = BaseMapping.ComputeX(t[0], t[1], t[2]);

            Assert.AreEqual(X.S, xs);
            Assert.AreEqual(X.R, xr);
            Assert.AreEqual(X.T, xt);

        }

        [TestMethod]
        public void ComputeX_ShouldThrowErrorForInvalidValues()
        {
            var v1 = new bool[] { true, false, true };
            var v2 = new bool[] { false, true, false };
            
        }

        [TestMethod]
        public void ComputeY_ShouldReturnCorrectYValues()
        {
            var input = new int[] { 2, 3, 4 };

            var actualYs = BaseMapping.ComputeY(X.S, input[0],input[1],input[2]);
            var actualYr = BaseMapping.ComputeY(X.R, input[0], input[1], input[2]);
            var actualYt = BaseMapping.ComputeY(X.T, input[0], input[1], input[2]);

            var expectedYs = 2 + ((double)2 * 3 / 100);
            var expectedYr = 2 + ((double)2 * (3 - 4) / 100);
            var expectedYt = 2 - ((double)2 * 4 / 100);

            Assert.AreEqual(expectedYs, actualYs);
            Assert.AreEqual(expectedYr, actualYr);
            Assert.AreEqual(expectedYt, actualYt);

        }
    }
}
