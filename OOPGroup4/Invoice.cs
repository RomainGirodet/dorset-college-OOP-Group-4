using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGroup4
{
    class Invoice
    {
        // test push
        private string title;
        private double amount;
        private DateTime deadline;
        private List<Payment> payments;
        public Invoice(string title, double amount, DateTime deadline)
        {
            this.title = title;
            this.amount = amount;
            this.deadline = deadline;
        }
        public string Title
        {
            get
            {
                return this.title;
            }

            set
            {
                this.title = value;
            }
        }
        public double Amount
        {
            get
            {
                return this.amount;
            }

            set
            {
                this.amount = value;
            }
        }
        public DateTime Deadline
        {
            get
            {
                return this.deadline;
            }

            set
            {
                this.deadline = value;
            }
        }
        public List<Payment> Payments
        {
            get
            {
                return payments;
            }

            set
            {
                this.payments = value;
            }
        }
    }
}
