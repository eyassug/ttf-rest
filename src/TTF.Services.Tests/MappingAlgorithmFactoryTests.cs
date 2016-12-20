using Microsoft.VisualStudio.TestTools.UnitTesting;
using TTF.Services.Algorithms;

namespace TTF.Services.Tests
{
    [TestClass]
    public class MappingAlgorithmFactoryTests
    {
        
        [TestMethod]
        public void BaseMapping_ShouldReturnBaseMappingAlgorithm()
        {
            var factory = new MappingAlgorithmFactory();
            var algorithm = factory.GetMappingAlgorithm(MappingAlgorithmTypes.Base);
            Assert.IsNotNull(algorithm);
            Assert.AreEqual(typeof(BaseMapping), algorithm.GetType());
        }

        
        [TestMethod]
        public void Specialized1_ShouldReturnSpecialized1MappingAlgorithm()
        {
            var factory = new MappingAlgorithmFactory();
            var algorithm = factory.GetMappingAlgorithm(MappingAlgorithmTypes.Specialized1);
            Assert.IsNotNull(algorithm);
            Assert.AreEqual(typeof(Specialized1), algorithm.GetType());
        }

        [TestMethod]
        public void Specialized2_ShouldReturnSpecialized2MappingAlgorithm()
        {
            var factory = new MappingAlgorithmFactory();
            var algorithm = factory.GetMappingAlgorithm(MappingAlgorithmTypes.Specialized2);
            Assert.IsNotNull(algorithm);
            Assert.AreEqual(typeof(Specialized2), algorithm.GetType());
        }
    }
}
