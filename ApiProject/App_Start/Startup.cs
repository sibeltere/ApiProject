using System;
using System.Threading.Tasks;
using System.Web.Http;
using ApiProject.Providers;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;

[assembly: OwinStartup(typeof(ApiProject.App_Start.Startup))]

namespace ApiProject.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888

            HttpConfiguration config = new HttpConfiguration();

            ConfigureOAuth(app);
            WebApiConfig.Register(config);
            app.UseWebApi(config);
        }

        public void ConfigureOAuth(IAppBuilder app)
        {
            OAuthAuthorizationServerOptions options = new OAuthAuthorizationServerOptions()
            {
                TokenEndpointPath = new Microsoft.Owin.PathString("/Authorization/GetToken"), //token alacağımız url
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1), //tokenın geçerlilik süresi
                AllowInsecureHttp = true,
                Provider = new AuthorizationServerProvider() // Oluşturduğumuz Providers

            };

            // AppBuilder'a token üretimini gerçekleştirebilmek için ilgili authorization ayarlarımız verilir
            app.UseOAuthAuthorizationServer(options);

            // Yetkilendirme tipi olarak Bearer Authentication'ı kullanacağımızı belirtiyoruz
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }
    }
}
