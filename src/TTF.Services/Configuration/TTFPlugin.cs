using ServiceStack;
using ServiceStack.Validation;

namespace TTF.Services.Configuration
{
    /// <summary>
    /// Used by ServiceStack AppHost to register and load dependencies
    /// </summary>
    public class TTFPlugin : IPlugin
    {
        public void Register(IAppHost appHost)
        {
            appHost.LoadPlugin(new ValidationFeature());
            appHost.RegisterAs<MappingAlgorithmFactory, IMappingAlgorithmFactory>();
        }
    }
}
