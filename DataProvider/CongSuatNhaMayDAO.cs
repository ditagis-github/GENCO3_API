using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider
{
    public class CongSuatNhaMayDAO
    {
        public double layNhaMayPhuMy(string id)
        {
            try
            {
                using (var context = new ScadaWebService.WebServiceGISSoapClient())
                {
                    var result = context.getCongSuat_PM1_GT11(id);
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
