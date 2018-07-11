using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataProvider;
using DataProvider.Models;

namespace WebAPI.Controllers
{

    [Authorize]
    [RoutePrefix("api/layerinfo")]
    public class LayerInfoController: ApiController
    {
        private AccountDB context = new AccountDB();
        [Route("{id}")]
        public HttpResponseMessage Get(string id)
        {
            try
            {
                var result = context.LayerInfos(new DataProvider.EF.SYS_Account
                {
                    Username = id
                });
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception e)
            {

                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e.Message);
            }
        }
        [Route("abc")]
        public HttpResponseMessage abc()
        {
            try
            {
                var result = context.LayerInfos(new DataProvider.EF.SYS_Account
                {
                    Username = "ditagis"
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
