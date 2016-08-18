using Microsoft.Owin.Security;
using Microsoft.Owin.Security.DataHandler;
using Microsoft.Owin.Security.DataProtection;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Http;

namespace OAuth.Api.Controllers
{
    [RoutePrefix("api/account")]
    public class AccountController : ApiController
    {
        [Authorize]
        [Route("")]
        public async Task<HttpResponseMessage> Get()
        {
            var rt = Request.GetOwinContext().Request.Headers.Get("Authorization");
            var ba = rt.Replace("Bearer ", "");

            var p = Startup.OAuthServerOptions.AccessTokenFormat.Unprotect(ba);
            var email = p.Properties.Dictionary.FirstOrDefault(x => x.Key == "userName");

            return Request.CreateResponse(HttpStatusCode.OK, "Success " + User.Identity.Name);
        }
    }
}
