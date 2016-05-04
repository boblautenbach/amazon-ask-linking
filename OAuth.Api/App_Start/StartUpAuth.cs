using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using OAuth.Api.Providers;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using OAuth.Logic.Services;
using OAuth.Logic.Interfaces;

[assembly: OwinStartup(typeof(OAuth.Api.Startup))]
namespace OAuth.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();

            var builder = new ContainerBuilder();
            builder.RegisterType<UserService>().As<IUserService>().InstancePerRequest();

            builder.RegisterWebApiFilterProvider(GlobalConfiguration.Configuration);
            IContainer container = builder.Build();

            // Create the depenedency resolver.
            var resolver = new AutofacWebApiDependencyResolver(container);

            // Configure Web API with the dependency resolver.
            GlobalConfiguration.Configuration.DependencyResolver = resolver;

            ConfigureOAuth(app);

            WebApiConfig.Register(config);
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            app.UseWebApi(config);
        }

        public void ConfigureOAuth(IAppBuilder app)
        {
            OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
               // AuthorizeEndpointPath = new PathString("/api/account/auth"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                Provider = new CustomProvider()
            };

            // Token Generation
            app.UseOAuthAuthorizationServer(OAuthServerOptions);

            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions
            {
                AuthenticationType = "Bearer",
                AuthenticationMode = Microsoft.Owin.Security.AuthenticationMode.Active,

            });

        }
    }
}