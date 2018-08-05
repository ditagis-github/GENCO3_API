using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataProvider;

namespace Web_API.Controllers
{
    [RoutePrefix("api/Account")]
    [Authorize]
    public class AccountController : ApiController
    {
        private AccountDB provider = new AccountDB();

        [HttpGet]
        [Route("Profile")]
        public HttpResponseMessage Profile()
        {
            try
            {
                var user = User.Identity;
                var result = this.provider.Profile(user.Name);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e.Message);
            }
        }

        [HttpGet]
        [Route("LayerInfo")]
        public HttpResponseMessage LayerInfo()
        {
            try
            {
                var user = User.Identity;
                var result = provider.LayerInfos(new DataProvider.EF.SYS_Account
                {
                    Username = user.Name
                });
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception e)
            {

                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e.Message);
            }
        }
    }
}
