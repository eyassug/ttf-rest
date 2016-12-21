using System;
using Funq;
using TTF.Services.Configuration;

namespace TTF.ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            int port;
            // Set 8000 if port number is not specified
            if (args.Length == 0 || !int.TryParse(args[0], out port))
                port = 8000;

            var appHost = new AppHost().Init().Start(string.Format("http://*:{0}/", port));
            Console.WriteLine("Dev server running at port: {0}", port);
            Console.ReadLine();
        }
    }

    public class AppHost : ServiceStack.AppSelfHostBase
    {
        public AppHost() : base("ttf-services", typeof(TTFPlugin).Assembly)
        {

        }

        public override void Configure(Container container)
        {
            Plugins.Add(new TTFPlugin());
        }
    }
}   
