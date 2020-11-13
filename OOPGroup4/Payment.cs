using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGroup4
{
    class Payment
    {
        private string invoice_title;
        private string payer_name;
        private PaymentMethodEnum payment_method;
        private double amount;
        private DateTime date;
        public Payment(string invoice_title,string payer_name, PaymentMethodEnum payment_method, double amount)
        {
            this.invoice_title = invoice_title;
            this.payer_name = payer_name;
            this.payment_method = payment_method;
            this.amount = amount;
        }
        public string Invoice_title
        {
            get
            {
                return this.invoice_title;
            }
        }
        public string Payer_name
        {
            get
            {
                return this.payer_name;
            }
        }
        public PaymentMethodEnum Payment_method
        {
            get
            {
                return this.payment_method;
            }
        }
        public double Amount
        {
            get
            {
                return this.amount;
            }
        }
        public DateTime Date
        {
            get
            {
                return this.date;
            }
        }
    }
}
