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
            return Request.CreateResponse(HttpStatusCode.OK, "Success " + User.Identity.Name);
        }
    }
}
