using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGroup4
{
    class Payment
    {
        private string payer_name;
        private string payment_method;
        private double amount;
        private DateTime date;
        public Payment(string payer_name, string payment_method, double amount)
        {
            this.payer_name = payer_name;
            this.payment_method = payment_method;
            this.amount = amount;
        }
    }
}
