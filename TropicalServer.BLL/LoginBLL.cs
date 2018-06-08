using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TropicalServer.DAL;

namespace TropicalServer.BLL
{
    public class LoginBLL
    {
        public bool CheckLoginCred(string userID, string passID)
        {
            var loginDS = new LoginDAL().GetLoginCred(userID, passID);

            if (loginDS == null) { return false; }

            return( 
                loginDS.Tables[0].Rows[0]["UserID"].Equals(userID) && 
                loginDS.Tables[0].Rows[0]["PassWord"].Equals(passID)
                ) 
                ? true : false;
        }
    }
}
