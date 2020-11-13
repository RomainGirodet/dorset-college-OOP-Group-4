using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGroup4
{
    class Member_of_school : School
    {
        string id;
        string name;
        string surname;
        string password;
        int age;
        string sexe;
        string mail;

        public  Member_of_school(string place, string school_name,string id,string name, string surname,string password, 
            int age, string sexe, string mail ) : base( place,  name )
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.password = password;
            this.age = age;
            this.sexe = sexe;
            this.mail = mail;
        }
        public string Id
        {
            get { return this.id; }
        }
        public string Name
        {
            get { return this.name; }
        }
        public string Surname
        {
            get { return this.surname; }
        }
        public string Password
        {
            get { return this.password; }
        }
        public int Age
        {
            get { return this.age; }
        }
        public string Sexe
        {
            get { return this.sexe; }
        }
        public string Mail
        {
            get { return this.mail; }
        }
    }
}
