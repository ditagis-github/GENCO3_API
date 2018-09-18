using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataProvider;
using DataProvider.Models;
using DataProvider.SystemManagement;
using DataProvider.EF;

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

        [Route("ApplyEdits")]
        [AllowAnonymous]
        public HttpResponseMessage ApplyEdits([FromBody] ApplyEdits datas)
        {
            try
            {
                var loggerContext = new LoggerLayerDB();
                var loggers = new List<SYS_Logger_Layer>();
                if (datas.addFeatures != null && datas.addFeatures.Count > 0)
                {
                    foreach (var graphic in datas.addFeatures)
                    {
                        var tacVu = "Thêm lớp dữ liệu";
                        var thuocTinh = "";
                        foreach (var key in graphic.attributes)
                        {
                            thuocTinh += key + ";";
                        }
                        loggers.Add(new SYS_Logger_Layer
                        {
                            TacVu = tacVu,
                            ThuocTinh = thuocTinh,
                            ThoiGian = DateTime.Now
                        });
                    }
                }
                if (datas.updateFeatures != null && datas.updateFeatures.Count > 0)
                {
                    foreach (var graphic in datas.updateFeatures)
                    {
                        var tacVu = "Cập nhật dữ liệu";
                        var thuocTinh = "";
                        foreach (var key in graphic.attributes)
                        {
                            thuocTinh += key + ";";
                        }
                        loggers.Add(new SYS_Logger_Layer
                        {
                            TacVu = tacVu,
                            ThuocTinh = thuocTinh,
                            ThoiGian = DateTime.Now
                        });
                    }
                }
                if (datas.deleteFeatures != null && datas.deleteFeatures.Count > 0)
                {
                    foreach (var graphic in datas.deleteFeatures)
                    {
                        var tacVu = "Xóa lớp dữ liệu";
                        var thuocTinh = "";
                        foreach (var key in graphic.attributes)
                        {
                            thuocTinh += key + ";";
                        }
                        loggers.Add(new SYS_Logger_Layer
                        {
                            TacVu = tacVu,
                            ThuocTinh = thuocTinh,
                            ThoiGian = DateTime.Now
                        });
                    }
                }
                var result = loggerContext.Create(loggers);
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
