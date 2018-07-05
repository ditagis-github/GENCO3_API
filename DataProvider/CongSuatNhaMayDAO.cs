﻿namespace DataProvider
{
    using System;

    /// <summary>
    /// Defines the <see cref="CongSuatNhaMayDAO" />
    /// </summary>
    public class CongSuatNhaMayDAO
    {
        /// <summary>
        /// Defines the context
        /// </summary>
        private ScadaWebService.WebServiceGISSoapClient context = new ScadaWebService.WebServiceGISSoapClient();

        /// <summary>
        /// The GetBuonKuop_H1
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetBuonKuop_H1()
        {
            try
            {
                var result = context.getCongSuat_BK_H1(Constant.ID);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// The GetBuonKuop_H2
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetBuonKuop_H2()
        {
            try
            {
                var result = context.getCongSuat_BK_H2(Constant.ID);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// The GetBuonTuaSarh_H1
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetBuonTuaSarh_H1()
        {
            try
            {
                var result = context.getCongSuat_BTS_H1(Constant.ID);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// The GetBuonTuaSarh_H2
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetBuonTuaSarh_H2()
        {
            try
            {
                var result = context.getCongSuat_BTS_H2(Constant.ID);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// The GetMongDuong1_S1
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetMongDuong1_S1()
        {
            try
            {
                var result = context.getCongSuat_MD1_S1(Constant.ID);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// The GetMongDuong1_S2
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetMongDuong1_S2()
        {
            try
            {
                var result = context.getCongSuat_MD1_S2(Constant.ID);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// The GetPhuMy1_GT11
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetPhuMy1_GT11()
        {
            try
            {
                var result = context.getCongSuat_PM1_GT11(Constant.ID);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// The GetPhuMy1_GT12
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetPhuMy1_GT12()
        {
            try
            {
                var result = context.getCongSuat_PM1_GT12(Constant.ID);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// The GetPhuMy1_GT13
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetPhuMy1_GT13()
        {
            try
            {
                var result = context.getCongSuat_PM1_GT13(Constant.ID);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// The GetPhuMy1_ST14
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetPhuMy1_ST14()
        {
            try
            {
                var result = context.getCongSuat_PM1_ST14(Constant.ID);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// The GetPhuMy21MR_GT24
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetPhuMy21MR_GT24()
        {
            try
            {
                var result = context.getCongSuat_PM21MR_GT24(Constant.ID);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// The GetPhuMy21MR_GT25
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetPhuMy21MR_GT25()
        {
            try
            {
                var result = context.getCongSuat_PM21MR_GT25(Constant.ID);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// The GetPhuMy21MR_ST26
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetPhuMy21MR_ST26()
        {
            try
            {
                var result = context.getCongSuat_PM21MR_ST26(Constant.ID);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// The GetPhuMy21_GT21
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetPhuMy21_GT21()
        {
            try
            {
                var result = context.getCongSuat_PM21_GT21(Constant.ID);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// The GetPhuMy21_GT22
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetPhuMy21_GT22()
        {
            try
            {
                var result = context.getCongSuat_PM21_GT22(Constant.ID);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// The GetPhuMy21_ST23
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetPhuMy21_ST23()
        {
            try
            {
                var result = context.getCongSuat_PM21_ST23(Constant.ID);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// The GetPhuMy4_GT41
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetPhuMy4_GT41()
        {
            try
            {
                var result = context.getCongSuat_PM4_GT41(Constant.ID);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// The GetPhuMy4_GT42
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetPhuMy4_GT42()
        {
            try
            {
                var result = context.getCongSuat_PM4_GT42(Constant.ID);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// The GetPhuMy4_ST43
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetPhuMy4_ST43()
        {
            try
            {
                var result = context.getCongSuat_PM4_ST43(Constant.ID);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// The GetSrePok3_H1
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetSrePok3_H1()
        {
            try
            {
                var result = context.getCongSuat_SP3_H1(Constant.ID);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// The GetSrePok3_H2
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetSrePok3_H2()
        {
            try
            {
                var result = context.getCongSuat_SP3_H2(Constant.ID);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// The GetVinhTan2_S1
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetVinhTan2_S1()
        {
            try
            {
                var result = context.getCongSuat_VT2_S1(Constant.ID);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// The GetVinhTan2_S2
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetVinhTan2_S2()
        {
            try
            {
                var result = context.getCongSuat_VT2_S2(Constant.ID);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
