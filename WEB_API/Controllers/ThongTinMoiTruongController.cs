using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataProvider;

namespace WEB_API.Controllers
{

    [RoutePrefix("thongtinmoitruong")]
    public class ThongTinMoiTruongController : ApiController
    {
        private ThongTinMoiTruongDAO thongTinMoiTruongDAO = new ThongTinMoiTruongDAO();
        // GET api/<controller>/5
        public double Get(string id)
        {
            CongSuatNhaMayDAO a = new CongSuatNhaMayDAO();
            if (id == "BK")
            {
                return a.GetBuonKuop_H1();

            }
            else if (id == "PM")
            {
                return a.GetPhuMy1_GT11();
            }
            return 0;

        }
        [Route("test")]
        [HttpGet]
        public double test(String id)
        {
            Console.WriteLine(id);
            if (id == "2")
                return thongTinMoiTruongDAO.GetCeMSVT2_CO2_S1();
            else return 0;
        }
        [Route("vinhtan2_s1")]
        [HttpGet]
        public double GetThongTinMoiTruongVinhTan2_S1(String id)
        {
            if (id == "CO2")
                return thongTinMoiTruongDAO.GetCeMSVT2_CO2_S1();
            else if (id == "CO")
                return thongTinMoiTruongDAO.GetCeMSVT2_CO_S1();
            else if (id == "Dust")
                return thongTinMoiTruongDAO.GetCeMSVT2_Dust_S1();
            else if (id == "NO2")
                return thongTinMoiTruongDAO.GetCeMSVT2_NO2_S1();
            else if (id == "O2")
                return thongTinMoiTruongDAO.GetCeMSVT2_O2_S1();
            else if (id == "SO2")
                return thongTinMoiTruongDAO.GetCeMSVT2_SO2_S1();
            else if (id == "Temp")
                return thongTinMoiTruongDAO.GetCeMSVT2_Temp_S1();
            else return 0;
        }
        [Route("vinhtan2_s2")]
        [HttpGet]
        public double GetThongTinMoiTruongVinhTan2_S2(String id)
        {
            if (id == "CO2")
                return thongTinMoiTruongDAO.GetCeMSVT2_CO2_S2();
            else if (id == "CO")
                return thongTinMoiTruongDAO.GetCeMSVT2_CO_S2();
            else if (id == "Dust")
                return thongTinMoiTruongDAO.GetCeMSVT2_Dust_S2();
            else if (id == "NO2")
                return thongTinMoiTruongDAO.GetCeMSVT2_NO2_S2();
            else if (id == "O2")
                return thongTinMoiTruongDAO.GetCeMSVT2_O2_S2();
            else if (id == "SO2")
                return thongTinMoiTruongDAO.GetCeMSVT2_SO2_S2();
            else if (id == "Temp")
                return thongTinMoiTruongDAO.GetCeMSVT2_Temp_S2();
            else return 0;
        }

    }
}