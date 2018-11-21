using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;


/**
* @author phuonghieuho
*
* @date - 11/19/2018 3:58:32 PM 
*/

namespace DataProvider.SystemManagement.AD
{
    public class LoginAD
    {
        public bool IsValid(string username, string password)
        {
            bool kq = false;
            string adPath = "LDAP://genco3";
            string domainAndUsername = "genco3" + @"\" + username;
            DirectoryEntry dir = new DirectoryEntry(adPath, domainAndUsername, password);
            try
            {
                //Bind to the native AdsObject to force authentication.
                object obj = dir.NativeObject;

                DirectorySearcher search = new DirectorySearcher(dir);

                search.Filter = "(SAMAccountName=" + username + ")";
                search.PropertiesToLoad.Add("cn");
                SearchResult result = search.FindOne();

                if (null == result)
                {
                    kq = false;
                }
                else
                {
                    kq = true;
                }

            }
            catch (Exception ex)
            {
                kq = false;
            }
            return kq;
        }
    }
}
