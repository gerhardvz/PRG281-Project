using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project_1
{
    class User
    {
        public String Username;
        public String Password; //Dont have to save password - just used for auth 
        //Scoreboard

       public User(String uname,String pass)
        {
            this.Username = uname;
            this.Password = pass;
         
        }
        public bool authenticate() {
            return true;

            
        }
        public bool UsernameIncorrect(string input)
        {
            string pattern = @"^a-zA-Z";
            if (Regex.Equals(input, pattern))
            {
                return true;
            }
            return false;
        }

        public void loadScore() { }
        public void addScore()
        {

        }

        public override string ToString()
        {

            return this.Username;
        }
       
    }
   
}
