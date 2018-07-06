using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataProvider;

namespace WEB_API.Controllers
{
    
    [RoutePrefix("congsuat")]
    public class CongSuatController : ApiController
    {
        private CongSuatNhaMayDAO congSuatNhaMayDAO = new CongSuatNhaMayDAO();
        // GET api/<controller>/5
        public double Get(string id)
        {
            CongSuatNhaMayDAO a = new CongSuatNhaMayDAO();
            if(id == "BK")
            {
                return a.GetBuonKuop_H1();

            }
            else if(id == "PM")
            {
                return a.GetPhuMy1_GT11();
            }
            return 0;

        }
        [Route("mongduong")]
        [HttpGet]
        public double LayNhaMayMongDuong()
        {
            CongSuatNhaMayDAO a = new CongSuatNhaMayDAO();
            return a.GetBuonKuop_H1();
        }

        [Route("buonkuop")]
        [HttpGet]
        public double GetBuonKuop_H1()
        {
            return congSuatNhaMayDAO.GetBuonKuop_H1() + congSuatNhaMayDAO.GetBuonKuop_H2();
        }
        [Route("phumy")]
        [HttpGet]
        public double GetCongSuatPhuMy()
        {
            return congSuatNhaMayDAO.GetPhuMy1_GT11() + congSuatNhaMayDAO.GetPhuMy1_GT12() + congSuatNhaMayDAO.GetPhuMy1_GT13() + congSuatNhaMayDAO.GetPhuMy1_ST14() +
                congSuatNhaMayDAO.GetPhuMy21MR_GT24() + congSuatNhaMayDAO.GetPhuMy21MR_GT25() + congSuatNhaMayDAO.GetPhuMy21MR_ST26() + congSuatNhaMayDAO.GetPhuMy21_GT21() +
                congSuatNhaMayDAO.GetPhuMy21_GT22() + congSuatNhaMayDAO.GetPhuMy21_ST23() + congSuatNhaMayDAO.GetPhuMy4_GT41() + congSuatNhaMayDAO.GetPhuMy4_GT42() +
                congSuatNhaMayDAO.GetPhuMy4_ST43();
        }
        [Route("vinhtan")]
        [HttpGet]
        public double GetCongSuatVinhTan()
        {
            //return congSuatNhaMayDAO.GetBuonKuop_H1();
            return congSuatNhaMayDAO.GetVinhTan2_S1() + congSuatNhaMayDAO.GetVinhTan2_S2();
        }
    }
}