﻿using System;
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
        private Timetable timetable;
        public Student(string id, string first_name, string last_name, string password,string date_of_birth, string gender, string mail) 
            : base(id, first_name, last_name, password, date_of_birth, gender, mail)
        {
            
        }
        void Pay(string invoice_title, string payer_name, PaymentMethodEnum payment_method, double amount)
        {
            Payment payment = new Payment(invoice_title, payer_name, payment_method, amount);
            if (invoice_list.Find(x => x.Title == invoice_title).Amount_left >= amount && payment.Date <= invoice_list.Find(x => x.Title == invoice_title).Deadline)
            {
                payment_list.Add(payment);
                invoice_list.Find(x => x.Title == invoice_title).Amount_left = invoice_list.Find(x => x.Title == invoice_title).Amount - amount;
                invoice_list.Find(x => x.Title == invoice_title).Payments.Add(payment);
            }
            else
            {
                Console.WriteLine("PAYMENT ERROR");
            }
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

        public Timetable Timetable
        {
            get { return timetable;}
        }
    }
}
