using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataProvider;

namespace WEB_API.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public Double Get(int id)
        {
            CongSuatNhaMayDAO congSuatNhaMayDAO = new CongSuatNhaMayDAO();
            return congSuatNhaMayDAO.GetBuonKuop_H1();
            //return "value";
        }
        public Double GetBuonKuop_H2()
        {
            CongSuatNhaMayDAO congSuatNhaMayDAO = new CongSuatNhaMayDAO();
            return congSuatNhaMayDAO.GetBuonKuop_H2();
            //return "value";
        }
        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
