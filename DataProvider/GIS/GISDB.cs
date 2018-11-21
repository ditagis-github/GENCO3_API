using DataProvider.Const.GISConstant;
using DataProvider.EF;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider.GIS
{
    public class GISDB
    {
        public string LayMaDoiTuong(string layerID,string maNhaMay)
        {
            using (var context = new GISEntities())
            {
                var shortName = String.Empty;
                var tableName = String.Empty;
                switch (layerID)
                {
                    case "baixiLYR":
                        shortName = "BXI";
                        tableName = "BAIXI";
                        break;
                    case "bangtaiLYR":
                        shortName = "BTI";
                        tableName = "BANGTAI";
                        break;
                    case "bechuaLYR":
                        shortName = "BCA";
                        tableName = "BECHUA";
                        break;
                    case "cameraLYR":
                        shortName = "CAA";
                        tableName = "CAMERA";
                        break;
                    case "cangLYR":
                        shortName = "CAG";
                        tableName = "CANG";
                        break;
                    case "congtrinhLYR":
                        shortName = "CTH";
                        tableName = "CONGTRINH";
                        break;
                    case "cotdienLYR":
                        shortName = "CDN";
                        tableName = "COTDIEN";
                        break;
                    case "cualaynuocLYR":
                        shortName = "CLN";
                        tableName = "CUALAYNUOC";
                        break;
                    case "dapdangLYR":
                        shortName = "DDG";
                        tableName = "DAPDANG";
                        break;
                    case "daptranxaluLYR":
                        shortName = "DTX";
                        tableName = "DAPTRANXALU";
                        break;
                    case "duongdaydienLYR":
                        shortName = "DDD";
                        tableName = "DUONGDAYDIEN";
                        break;
                    case "duongongLYR":
                        shortName = "DOG";
                        tableName = "DUONGONG";
                        break;
                    case "giaothongLYR":
                        shortName = "GTG";
                        tableName = "GIAOTHONG";
                        break;
                    case "hochuanuocngotLYR":
                        shortName = "HCN";
                        tableName = "HOCHUANUOCNGOT";
                        break;
                    case "hogaLYR":
                        shortName = "HGA";
                        tableName = "HOGA";
                        break;
                    case "kenhdanLYR":
                        shortName = "KDN";
                        tableName = "KENHDAN";
                        break;
                    case "kenhnuoclammatLYR":
                        shortName = "KNL";
                        tableName = "KENHNUOCLAMMAT";
                        break;
                    case "luuvucLYR":
                        shortName = "LVC"; tableName = "LUUVUC";
                        break;
                    case "nhamaydienLYR":
                        shortName = "NMD"; tableName = "NHAMAYDIEN";
                        break;
                    case "songhoLYR":
                        shortName = "SHO"; tableName = "SONGHO";
                        break;
                    case "thapdieuapLYR":
                        shortName = "TDA"; tableName = "THAPDIEUAP";
                        break;
                    case "tomaynhietdienLYR":
                        shortName = "TMN"; tableName = "TOMAYNHIETDIEN";
                        break;
                    case "trambienapLYR":
                        shortName = "TBA"; tableName = "TRAMBIENAP";
                        break;
                    case "trambomLYR":
                        shortName = "TBM"; tableName = "TRAMBOM";
                        break;
                    case "trusocongtyLYR":
                        shortName = "TSC";
                        break;
                    case "tuyenduongthaixiLYR":
                        shortName = "TDT"; tableName = "TUYENDUONGTHAIXI";
                        break;
                    case "tuyennangluongLYR":
                        shortName = "TNL"; tableName = "TUYENNANGLUONG";
                        break;
                }

                if (!String.IsNullOrEmpty(shortName))
                {
                    var sql = String.Format("select top 1 MaNhaMay+'/'+'{0}'+REPLACE(STR(count(MaNhaMay) + 1,4), SPACE(1), '0')  from {1} where MaNhaMay = @maNhaMay group by MaNhaMay order by MaNhaMay desc",
                        shortName, tableName,maNhaMay
                        );
                    var maDoiTuong = context.Database.SqlQuery<string>(sql,new SqlParameter("maNhaMay",maNhaMay))
                        .DefaultIfEmpty(String.Format("{0}/{1}0001", maNhaMay, shortName))
                        .FirstOrDefault();
                    return maDoiTuong;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }
    }
}
