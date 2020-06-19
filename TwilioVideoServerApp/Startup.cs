using Microsoft.Extensions.DependencyInjection;
using Microsoft.Owin;
using Owin;
using TwilioVideoServerApp.Abstractions;
using TwilioVideoServerApp.Options;
using TwilioVideoServerApp.Services;

[assembly: OwinStartup(typeof(TwilioVideoServerApp.Startup))]

namespace TwilioVideoServerApp
{
    public class Startup
    {

        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
        }
    }
}
