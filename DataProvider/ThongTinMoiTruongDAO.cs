using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider
{
    public class ThongTinMoiTruongDAO
    {
        public double layMoiTruongVinhTan(string id)
        {
            try
            {
                using (var context = new ScadaWebService.WebServiceGISSoapClient())
                {
                    var result = context.getCeMSVT2_CO_S1(id);
                    return result;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
