using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGroup4
{
    class Member_of_school 
    {
        string id;
        string first_name;
        string last_name;
        string password;
        string  date_of_birth;
        string gender;
        string mail;

        public  Member_of_school(string id,string first_name, string last_name,string password, 
            string  date_of_birth, string gender, string mail ) 
        {
            this.id = id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.password = password;
            this.date_of_birth = date_of_birth;
            this.gender = gender;
            this.mail = mail;
        }
        public string Id
        {
            get { return this.id; }
        }
        public string First_name
        {
            get { return this.first_name; }
        }
        public string Last_name
        {
            get { return this.last_name; }
        }
        public string Password
        {
            get { return this.password; }
        }
        public string  Date_of_birth
        {
            get { return this.date_of_birth; }
        }
        public string Gender
        {
            get { return this.gender; }
        }
        public string Mail
        {
            get { return this.mail; }
        }
    }
}
