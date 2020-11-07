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
    }
}
