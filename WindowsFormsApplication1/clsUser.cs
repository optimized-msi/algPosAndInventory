using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   public class clsUser
    {
        private string userID,gName,privelege;

        public void SetUserID(string userID)
        {
            this.userID = userID;
        }
        public string GetUserID()
        {
            return this.userID;
        }
        public void SetGName(string gName)
        {
            this.gName = gName;
        }
        public string GetGName()
        {
            return this.gName;
        }
        public void SetPrivelge(string privelege)
        {
            this.privelege = privelege;
        }
        public string GetPrivelege()
        {
            return this.privelege;
        }
    }
}
