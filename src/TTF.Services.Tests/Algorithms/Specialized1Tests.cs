using Microsoft.VisualStudio.TestTools.UnitTesting;
using TTF.Services.Algorithms;
using TTF.Services.Models;

namespace TTF.Services.Tests.Algorithms
{
    [TestClass]
    public class Specialized1Tests
    {
        [TestMethod]
        public void ComputeY_ShouldReturnCorrectYValues()
        {
            // X = R => Y = 2D + (D * E / 100)
            var actualYr = Specialized1.ComputeY(X.R, 2, 3, 4);
            // (X = S || X = T) => BaseMapping.ComputeY();
            var actualYs = Specialized1.ComputeY(X.S, 2, 3, 4);
            var actualYt = Specialized1.ComputeY(X.T, 2, 3, 4);

            // expectedYr = 2*2 + (2*3/100) = 4 + (.06) = 4.06
            var expectedYr = 4.06;
            var expectedYs = BaseMapping.ComputeY(X.S, 2, 3, 4);
            var expectedYt = BaseMapping.ComputeY(X.T, 2, 3, 4);
            
            
            Assert.AreEqual(expectedYr, actualYr);
            Assert.AreEqual(expectedYs, actualYs);
            Assert.AreEqual(expectedYt, actualYt);
        }
    }
}
