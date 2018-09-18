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

        private string chuyenDoiCongSuat(double congSuat)
        {
            return Math.Round(congSuat, 2) + " (MW)";
        }
        // GET api/<controller>/5
        [Route("mongduong1")]
        [HttpGet]
        public HttpResponseMessage GetMongDuong1()
        {
            return Request.CreateResponse(HttpStatusCode.OK,
             new
             {
                 S1 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetMongDuong1_S1()),
                 S2 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetMongDuong1_S2()),

             });
        }

        [Route("buonkuop")]
        [HttpGet]
        public HttpResponseMessage GetBuonKuop()
        {
            return Request.CreateResponse(HttpStatusCode.OK,
              new
              {
                  H1 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetBuonKuop_H1()),
                  H2 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetBuonKuop_H2()),

              });
        }
        [Route("phumy1")]
        [HttpGet]
        public HttpResponseMessage GetCongSuatPhuMy1()
        {
            return Request.CreateResponse(HttpStatusCode.OK,
                new
                {
                    GT11 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetPhuMy1_GT11()),
                    GT12 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetPhuMy1_GT12()),
                    GT13 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetPhuMy1_GT13()),
                    GT14 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetPhuMy1_ST14())

                });
        }
        [Route("phumy21")]
        [HttpGet]
        public HttpResponseMessage GetCongSuatPhuMy21()
        {
            return Request.CreateResponse(HttpStatusCode.OK,
                new
                {
                    GT21 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetPhuMy21_GT21()),
                    GT22 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetPhuMy21_GT22()),
                    ST23 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetPhuMy21_ST23()),
                    GT24 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetPhuMy21MR_GT24()),
                    GT25 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetPhuMy21MR_GT25()),
                    ST26 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetPhuMy21MR_ST26())

                });
        }
        [Route("phumy22")]
        [HttpGet]
        public HttpResponseMessage GetCongSuatPhuMy22()
        {
            return Request.CreateResponse(HttpStatusCode.OK,
                new
                {
                    Total = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetPhuMy22_Total())

                });
        }

        [Route("phumy3")]
        [HttpGet]
        public HttpResponseMessage GetCongSuatPhuMy3()
        {
            return Request.CreateResponse(HttpStatusCode.OK,
                new
                {
                    GT31 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetCongSuat_PM3_GT31()),
                    GT32 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetCongSuat_PM3_GT32()),
                    ST33 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetCongSuat_PM3_ST33())
                });
        }

        [Route("phumy4")]
        [HttpGet]
        public HttpResponseMessage GetCongSuatPhuMy4()
        {
            return Request.CreateResponse(HttpStatusCode.OK,
                new
                {
                    GT41 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetPhuMy4_GT41()),
                    GT42 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetPhuMy4_GT42()),
                    ST43 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetPhuMy4_ST43())
                });
        }

        [Route("baria")]
        [HttpGet]
        public HttpResponseMessage GetCongSuatBaRia()
        {
            return Request.CreateResponse(HttpStatusCode.OK,
                new
                {
                    GT1 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetCongSuat_BR_GT1()),
                    GT2 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetCongSuat_BR_GT2()),
                    GT3 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetCongSuat_BR_GT3()),
                    GT4 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetCongSuat_BR_GT4()),
                    GT5 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetCongSuat_BR_GT5()),
                    GT6 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetCongSuat_BR_GT6()),
                    GT7 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetCongSuat_BR_GT7()),
                    GT8 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetCongSuat_BR_GT8()),
                    ST10 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetCongSuat_BR_ST10()),
                    ST9 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetCongSuat_BR_ST9())
                });
        }

        [Route("srepok3")]
        [HttpGet]
        public HttpResponseMessage GetCongSuatSrepok3()
        {
            return Request.CreateResponse(HttpStatusCode.OK,
                new
                {
                    H1 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetSrePok3_H1()),
                    H2 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetSrePok3_H2())
                });
        }
        [Route("thaibinh1")]
        [HttpGet]
        public HttpResponseMessage GetCongSuatThaiBinh1()
        {
            return Request.CreateResponse(HttpStatusCode.OK,
                new
                {
                    S1 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetCongSuat_TB1_S1()),
                    S2 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetCongSuat_TB1_S2())
                });
        }

        [Route("vinhtan2")]
        [HttpGet]
        public HttpResponseMessage GetCongSuatVinhTan2()
        {
            return Request.CreateResponse(HttpStatusCode.OK,
                new
                {
                    S1 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetVinhTan2_S1()),
                    S2 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetVinhTan2_S2())
                });
        }

        [Route("vinhtan4")]
        [HttpGet]
        public HttpResponseMessage GetCongSuatVinhTan4()
        {
            return Request.CreateResponse(HttpStatusCode.OK,
                new
                {
                    Ngay = congSuatNhaMayDAO.GetCongSuat_VT4_NGAY(),
                    S1 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetCongSuat_VT4_S1()),
                    S2 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetCongSuat_VT4_S2())
                });
        }

        [Route("buontuasrah")]
        [HttpGet]
        public HttpResponseMessage GetCongSuatBuonTuaSrah()
        {
            return Request.CreateResponse(HttpStatusCode.OK,
                new
                {
                    H1 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetBuonTuaSarh_H1()),
                    H2 = this.chuyenDoiCongSuat(congSuatNhaMayDAO.GetBuonTuaSarh_H2())
                });
        }
    }
}