using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DataProvider.EF;
using DataProvider.Models;
using DataProvider.SystemManagement.AD;

namespace DataProvider.SystemManagement
{
    public class AccountDB
    {
        public static readonly string LADP = @"genco3\";
        public SYS_Account CheckSession(string pSSID)
        {
            using (var context = new OnlinePortal())
            {
                var sql = "select LoginName from  TableAdUser  where LoginUserSessionId=@p0";
                var username = context.Database.SqlQuery<string>(sql, pSSID).FirstOrDefault();
                if (username != null)
                {
                    using (var systemContext = new SystemEntities())
                    {
                        return systemContext.SYS_Account.FirstOrDefault(f => f.Username.Equals(@"genco3\" + username));
                    }
                }
                else
                {
                    return null;
                }
            }
        }
        public List<LayerInfo> LayerInfos(SYS_Account account)
        {
            try
            {
                using (var context = new SystemEntities())
                {
                    var query = from la in context.SYS_Layer_Account
                                join lyr in context.SYS_Layer on la.Layer equals lyr.ID
                                join gr in context.SYS_GroupLayer on lyr.GroupID equals gr.ID into igr
                                from gr in igr.DefaultIfEmpty()
                                where la.Account == account.Username
                                orderby lyr.NumericalOder
                                select new LayerInfo
                                {
                                    LayerID = lyr.ID,
                                    LayerTitle = lyr.Title,
                                    IsView = la.IsView.HasValue ? la.IsView.Value : false,
                                    IsCreate = la.IsCreate.HasValue ? la.IsCreate.Value : false,
                                    IsDelete = la.IsDelete.HasValue ? la.IsDelete.Value : false,
                                    IsEdit = la.IsEdit.HasValue ? la.IsEdit.Value : false,
                                    Definition = String.IsNullOrEmpty(la.Definition) ? null : la.Definition.Replace("\"", "'"),
                                    Url = lyr.Url,
                                    OutFields = la.OutFields,
                                    GroupID = gr.ID,
                                    GroupName = gr.Name
                                };

                    return query.ToList();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool IsDomainAccount(string pUsername)
        {
            using (var context = new SystemEntities())
            {
                var isValid = context.SYS_Account.Any(f => f.Username.Equals(LADP + pUsername));
                return isValid;
            }
        }

        public SYS_Account IsValid(SYS_Account account)
        {
            try
            {
                using (var context = new SystemEntities())
                {


                    var isDomainAccount = this.IsDomainAccount(account.Username);

                    // nếu trong dữ liệu user bắt đầu bằng LADP
                    if (isDomainAccount)
                    {
                        var userName = account.Username;
                        var isValid = new LoginAD().IsValid(userName, account.Password);
                        if (isValid)
                        {
                            return this.Get(LADP + account.Username);
                        }
                        else
                        {
                            return null;
                        }
                    }


                    var password = Helper.MD5.CryptoPassword(account.Password);
                    var sysAccount = context.SYS_Account.
                        FirstOrDefault(
                        f =>
                        f.Username.Equals(account.Username, StringComparison.OrdinalIgnoreCase)
                        && f.Password.Equals(password));
                    return sysAccount;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public SYS_Account Get(string pUsername)
        {
            using (var context = new SystemEntities())
            {
                return context.SYS_Account.FirstOrDefault(f => f.Username.Equals(pUsername));
            }
        }

        public SYS_Account Profile(string username)
        {
            try
            {
                using (var context = new SystemEntities())
                {
                    var query = from f in context.SYS_Account
                                where f.Username.Equals(username, StringComparison.OrdinalIgnoreCase)
                                select new AccountModel
                                {
                                    Username = f.Username,
                                    DisplayName = f.DisplayName
                                };
                    return query.FirstOrDefault();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
