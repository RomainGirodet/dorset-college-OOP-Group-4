using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGroup4
{
    class Member_of_school : School
    {
       
        private string id;
        public string name {get;set;}
        public string surname {get;set;}
        private string password ;
        public int age {get;set;}
        public string sexe {get;set;}
        private string email ;
        


        public  Member_of_school(string place, string school_name, int number_of_student,string id,string name, string surname,string password, 
            int age, string sexe, string email ) : base( place,  name, number_of_student)
        {
            this.id =id ;
            this.name =name ;
            this.surname = surname ;
            this.password =password ;
            this.age =age;
            this.sexe =sexe;
            this.email =email ;
        }
        public bool VerifyLogin(string idinsert , string passwordInsert){
        
                 if (passwordInsert == password & idinsert==id){
                 return true ;
                 }
                else {return false;}

        }

    }
}
