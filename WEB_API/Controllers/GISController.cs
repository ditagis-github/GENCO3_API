using DataProvider.GIS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;

namespace WEB_API.Controllers
{
    [RoutePrefix("api/GIS")]
    public class GISController : ApiController
    {
        private GISDB context = new GISDB();

        [Route("LayMaDoiTuong/{layerID}/{maNhaMay}")]
        [HttpGet]
        public HttpResponseMessage LayMaDoiTuong(string layerID,string maNhaMay)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, this.context.LayMaDoiTuong(layerID,maNhaMay));
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e.Message);
            }
        }
    }
}
