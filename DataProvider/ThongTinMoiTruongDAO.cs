namespace DataProvider
{
    using System;

    /// <summary>
    /// Defines the <see cref="ThongTinMoiTruongDAO" />
    /// </summary>
    public class ThongTinMoiTruongDAO
    {
        /// <summary>
        /// Defines the context
        /// </summary>
        private ScadaWebService.WebServiceGISSoapClient context = new ScadaWebService.WebServiceGISSoapClient();

        /// <summary>
        /// The GetCeMSVT2_CO2_S1
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetCeMSVT2_CO2_S1()
        {
            try
            {
                {
                    var result = context.getCeMSVT2_CO2_S1(Constant.ID);
                    return result;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        /// <summary>
        /// The GetCeMSVT2_CO2_S2
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetCeMSVT2_CO2_S2()
        {
            try
            {
                {
                    var result = context.getCeMSVT2_CO2_S2(Constant.ID);
                    return result;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        /// <summary>
        /// The GetCeMSVT2_CO_S1
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetCeMSVT2_CO_S1()
        {
            try
            {
                {
                    var result = context.getCeMSVT2_CO_S1(Constant.ID);
                    return result;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        /// <summary>
        /// The GetCeMSVT2_CO_S2
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetCeMSVT2_CO_S2()
        {
            try
            {
                {
                    var result = context.getCeMSVT2_CO_S2(Constant.ID);
                    return result;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        /// <summary>
        /// The GetCeMSVT2_Dust_S1
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetCeMSVT2_Dust_S1()
        {
            try
            {
                {
                    var result = context.getCeMSVT2_Dust_S1(Constant.ID);
                    return result;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        /// <summary>
        /// The GetCeMSVT2_Dust_S2
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetCeMSVT2_Dust_S2()
        {
            try
            {
                {
                    var result = context.getCeMSVT2_Dust_S2(Constant.ID);
                    return result;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        /// <summary>
        /// The GetCeMSVT2_NO2_S1
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetCeMSVT2_NO2_S1()
        {
            try
            {
                {
                    var result = context.getCeMSVT2_NO2_S1(Constant.ID);
                    return result;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        /// <summary>
        /// The GetCeMSVT2_NO2_S2
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetCeMSVT2_NO2_S2()
        {
            try
            {
                {
                    var result = context.getCeMSVT2_NO2_S2(Constant.ID);
                    return result;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        /// <summary>
        /// The GetCeMSVT2_O2_S1
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetCeMSVT2_O2_S1()
        {
            try
            {
                {
                    var result = context.getCeMSVT2_O2_S1(Constant.ID);
                    return result;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        /// <summary>
        /// The GetCeMSVT2_O2_S2
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetCeMSVT2_O2_S2()
        {
            try
            {
                {
                    var result = context.getCeMSVT2_O2_S2(Constant.ID);
                    return result;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        /// <summary>
        /// The GetCeMSVT2_SO2_S1
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetCeMSVT2_SO2_S1()
        {
            try
            {
                {
                    var result = context.getCeMSVT2_SO2_S1(Constant.ID);
                    return result;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        /// <summary>
        /// The GetCeMSVT2_SO2_S2
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetCeMSVT2_SO2_S2()
        {
            try
            {
                {
                    var result = context.getCeMSVT2_SO2_S2(Constant.ID);
                    return result;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        /// <summary>
        /// The GetCeMSVT2_Temp_S1
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetCeMSVT2_Temp_S1()
        {
            try
            {
                {
                    var result = context.getCeMSVT2_Temp_S1(Constant.ID);
                    return result;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        /// <summary>
        /// The GetCeMSVT2_Temp_S2
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetCeMSVT2_Temp_S2()
        {
            try
            {
                {
                    var result = context.getCeMSVT2_Temp_S2(Constant.ID);
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
