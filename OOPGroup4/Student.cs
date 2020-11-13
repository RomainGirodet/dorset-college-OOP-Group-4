using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGroup4
{
    class Student : Member_of_school
    {
        private List<Invoice> invoice_list;
        private List<Payment> payment_list;
        private List<Absence> absence_list; 
        private List<Evaluation> studentEvaluation;
        public Student(string place, string school_name, string id, string name, string surname, string password, int age, string sexe, string mail) : base(place, name, id, name, surname, password, age, sexe, mail)
        {

        }
        void Pay(string payer_name, string payment_method, double amount)
        {
            Payment payment = new Payment(payer_name, payment_method, amount);
            payment_list.Add(payment);
        }
       
        public List<Evaluation> StudentEvaluation()        
        {
            return studentEvaluation;
        }
        public List<Invoice> Invoice_list
        {
            get
            {
                return this.invoice_list;
            }

            set
            {
                this.invoice_list = value;
            }
        }
        public List<Payment> Payment_list
        {
            get
            {
                return this.payment_list;
            }
        }
        public List<Absence> Absence_list
        {
            get
            {
                return this.absence_list;
            }

            set
            {
                this.absence_list = value;
            }
        }
    }
}
