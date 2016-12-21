using Microsoft.VisualStudio.TestTools.UnitTesting;
using TTF.Services.Models;
using TTF.Services.Algorithms;

namespace TTF.Services.Tests.Algorithms
{
    [TestClass]
    public class Specialized2Tests
    {
        [TestMethod]
        public void ComputeX_ShouldReturnCorrectXValues()
        {
            // A && B && !C => X.T
            var actual1 = Specialized2.ComputeX(true, true, false);
            var expected1 = X.T;
            // A && !B && C => X.S
            var actual2 = Specialized2.ComputeX(true, false, true);
            var expected2 = X.S;

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);

        }

        [TestMethod]
        public void ComputeY_ShouldReturnCorrectYValues()
        {
            // X = S => Y = F + D + (D * E / 100)
            var actualYs = Specialized2.ComputeY(X.S, 2, 3, 4);
            // (X = R || X = T) => BaseMapping.ComputeY();
            var actualYr = Specialized2.ComputeY(X.R, 2, 3, 4);
            var actualYt = Specialized2.ComputeY(X.T, 2, 3, 4);

            // expectedYs = 4 + 2 + (2*3/100) = 6 + (.06) = 6.06
            var expectedYs = 6.06;
            var expectedYr = BaseMapping.ComputeY(X.R, 2, 3, 4);
            var expectedYt = BaseMapping.ComputeY(X.T, 2, 3, 4);


            Assert.AreEqual(expectedYr, actualYr);
            Assert.AreEqual(expectedYs, actualYs);
            Assert.AreEqual(expectedYt, actualYt);
        }
    }
}
