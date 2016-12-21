using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTF.Services.Models;
using TTF.Services.Validation;

namespace TTF.Services.Tests.Validation
{
    [TestClass]
    public class InputValidatorTests
    {
        [TestMethod]
        public void InvalidMappingType_ShouldFailValidation()
        {
            var validator = new InputValidator();
            var invalidValues = new string[] { null, "", "someValue" };
            foreach(var value in invalidValues)
            {
                var input = new Input { MappingType = value };
                var result = validator.Validate(input);
                Assert.IsNotNull(result);
                Assert.AreEqual(false, result.IsValid);
            }
        }

        [TestMethod]
        public void ValidMappingType_ShouldPassValidation()
        {
            var validator = new InputValidator();
            var validValues = new string[] { "base", "specialized1", "specialized2" };
            foreach (var value in validValues)
            {
                var input = new Input { MappingType = value };
                var result = validator.Validate(input);
                Assert.IsNotNull(result);
                Assert.AreEqual(true, result.IsValid);
            }
        }

        [TestMethod]
        public void ValidMappingType_ShouldIgnoreCaseAndPassValidation()
        {
            var validator = new InputValidator();
            var validValues = new string[] { "base", "Base", "specialized1", "specialIZed2" };
            foreach (var value in validValues)
            {
                var input = new Input { MappingType = value };
                var result = validator.Validate(input);
                Assert.IsNotNull(result);
                Assert.AreEqual(true, result.IsValid);
            }
        }
    }
}
