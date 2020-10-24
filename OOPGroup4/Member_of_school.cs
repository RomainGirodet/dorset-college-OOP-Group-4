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

        public  Member_of_school(string place, string school_name, int number_of_student,string id,string name, string surname,string password, 
            int age, string sexe, string mail ) : base( place,  name, number_of_student)
        {

        }
    }
}
