using ServiceStack;
using ServiceStack.FluentValidation;
using System;
using TTF.Services.Models;

namespace TTF.Services.API
{
    public class MappingService : Service
    {
        public IMappingAlgorithmFactory MappingAlgorithmFactory { get; set; }
        public IValidator<Input> InputValidator { get; set; }
        public object Any(Input request)
        {
            var result = InputValidator.Validate(request);
            if(result.IsValid)
            {
                var algorithm = MappingAlgorithmFactory.GetMappingAlgorithm(request.MappingType);
                return algorithm.Compute(request);
            }
            throw new Exception("Invalid mapping type");
        }
    }
}
