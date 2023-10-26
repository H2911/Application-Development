using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    //Class to create user object to store information of event
    public class User
    {
        private string userName;
        private int userID;
        private string userPassword;
        public enum userRolls { customer, admin };
        public string userRoll;
        public User( int userID, string userName, string userPassword, string userRoll)
        {
            this.userID = userID;
            this.userName = userName;
            this.userPassword = userPassword;
            this.userRoll = userRoll;
        }
        public string UserName { get { return userName; } }
        public int UserID { get { return userID; } } 
        public string UserRolls { get { return userRoll; } }
        public override string ToString()
        {
            return userID.ToString() + "," + userName + userPassword + "," + userRoll;
        }
    }
}
