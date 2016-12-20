namespace TTF.Services
{
    public enum MappingAlgorithmTypes
    {
        Base,
        Specialized1,
        Specialized2
    }
    /// <summary>
    /// An abstract factory that instantiate the desired Mapping Algorithm
    /// </summary>
    public interface IMappingAlgorithmFactory
    {
        IMappingAlgorithm GetMappingAlgorithm(MappingAlgorithmTypes type);
    }
}
