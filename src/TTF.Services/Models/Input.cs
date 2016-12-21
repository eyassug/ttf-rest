using ServiceStack;

namespace TTF.Services.Models
{
    /// <summary>
    /// Input model required by the REST service
    /// </summary>
    [Route("/ttf/{MappingType}")]
    public class Input : IInputX, IInputY, IReturn<Output>
    {
        public bool A { get; set; }
        public bool B { get; set; }
        public bool C { get; set; }
        public int D { get; set; }
        public int E { get; set; }
        public int F { get; set; }
        /// <summary>
        /// Used as part of the request to resolve the desired mapping type
        /// </summary>
        [ApiMember(Name = "MappingType", Description = "Mapping algorithm to be used", ParameterType = "path", DataType = "string", IsRequired = true)]
        [ApiAllowableValues("MappingType", typeof(MappingAlgorithmTypes))]
        public string MappingType { get; set; }
    }
}
