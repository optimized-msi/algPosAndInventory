using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   public class clsUser
    {
        private static string userID,gName,privelege,loginStatus;

        public void SetUserID(string userID)
        {
            clsUser.userID = userID;
        }
        public string GetUserID()
        {
            return userID;
        }
        public void SetGName(string gName)
        {
            clsUser.gName = gName;
        }
        public string GetGName()
        {
            return gName;
        }
        public void SetPrivelge(string privelege)
        {
            clsUser.privelege = privelege;
        }
        public string GetPrivelege()
        {
            return privelege;
        }
        public void SetLoginStatus(string loginStat)
        {
            clsUser.loginStatus = loginStat;
        }
        public string GetLoginStatus()
        {
            return loginStatus;
        }
    }
}
