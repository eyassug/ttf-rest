using System;
using TTF.Services.Algorithms;

namespace TTF.Services
{
    public class MappingAlgorithmFactory : IMappingAlgorithmFactory
    {
        public IMappingAlgorithm GetMappingAlgorithm(string typeString)
        {
            var algorithm = Enum.Parse(typeof(MappingAlgorithmTypes), typeString, ignoreCase:true);
            return GetMappingAlgorithm((MappingAlgorithmTypes)algorithm);
        }

        public IMappingAlgorithm GetMappingAlgorithm(MappingAlgorithmTypes type)
        {
            switch (type)
            {
                case MappingAlgorithmTypes.Specialized1:
                    return new Specialized1();
                case MappingAlgorithmTypes.Specialized2:
                    return new Specialized2();
                default:
                    return new BaseMapping();
            }
        }
    }
}
