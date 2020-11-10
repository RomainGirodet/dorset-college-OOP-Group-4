using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGroup4
{
    class Student : Member_of_school
    {
        private List<Payment> payment_list;
        private List<Absence> absence_list;
        public Student(string place, string school_name, string id, string name, string surname, string password, int age, string sexe, string mail) : base(place, name, id, name, surname, password, age, sexe, mail)
        {

        }
        void Pay(string payer_name, string payment_method, double amount)
        {

        }
        public List<Absence> Absence_list
        {
            get { return this.absence_list ; }
            set { this.absence_list=value ; }
        }
       
    }
}
