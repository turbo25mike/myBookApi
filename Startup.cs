using System.Web.Http;
using Owin;

namespace Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            appBuilder.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            var httpConfiguration = new HttpConfiguration();
            Config.Register(httpConfiguration);
            appBuilder.UseWebApi(httpConfiguration);
        }
    }
}
