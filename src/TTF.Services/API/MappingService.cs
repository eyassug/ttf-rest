using ServiceStack;
using System;
using TTF.Services.Models;

namespace TTF.Services.API
{
    public class MappingService : Service
    {
        public IMappingAlgorithmFactory MappingAlgorithmFactory { get; set; }
        public object Any(Input request)
        {
            throw new NotImplementedException();
        }
    }
}
