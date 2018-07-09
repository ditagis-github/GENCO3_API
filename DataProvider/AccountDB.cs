using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DataProvider.EF;
using DataProvider.Models;

namespace DataProvider
{
    public class AccountDB
    {
        public List<LayerInfo> LayerInfos(SYS_Account account)
        {
            try
            {
                using (var context = new SystemEntities())
                {
                    var query = from la in context.SYS_Layer_Account
                                join lyr in context.SYS_Layer on la.Layer equals lyr.ID
                                where la.Account == account.Username
                                orderby lyr.NumericalOder
                                select new LayerInfo
                                {
                                    LayerID = lyr.ID,
                                    LayerTitle = lyr.Title,
                                    IsView = la.IsView.HasValue?la.IsView.Value:false,
                                    IsCreate = la.IsCreate.HasValue?la.IsCreate.Value:false,
                                    IsDelete = la.IsDelete.HasValue?la.IsDelete.Value:false,
                                    IsEdit = la.IsEdit.HasValue?la.IsEdit.Value:false,
                                    Definition = la.Definition,
                                    Url = lyr.Url,
                                    OutFields = la.OutFields
                                };

                    return query.ToList();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public SYS_Account IsValid(SYS_Account account)
        {
            try
            {
                using (var context = new SystemEntities())
                {
                    var password = Helper.MD5.CryptoPassword(account.Password);
                    var sysAccount = context.SYS_Account.
                        FirstOrDefault(
                        f => 
                        f.Username.Equals(account.Username,StringComparison.OrdinalIgnoreCase)
                        && f.Password.Equals(password));
                    return sysAccount;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
