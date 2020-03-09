using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment
    {
        protected Payment(
            DateTime paidDate, 
            DateTime expirateDate, 
            decimal tital, 
            decimal totalPaid, 
            string payer, 
            Document document, 
            Address address, 
            Email email)
        {
            Number = Guid.NewGuid().ToString().Replace("-","").Substring(0,10).ToUpper();
            PaidDate = paidDate;
            ExpirateDate = expirateDate;
            Tital = tital;
            this.totalPaid = totalPaid;
            Payer = payer;
            Document = document;
            Address = address;
            Email = email;
        }

        public int MyProperty { get;private set; }
        public string Number  { get; private set; }
        public DateTime PaidDate  { get; private set; }
        public DateTime ExpirateDate  { get; private set; }
        public decimal Tital  { get; private set; }
        public decimal totalPaid  { get; private set; }
        public string Payer { get; private set; }
        public Document Document { get; private set; }
        public Address Address { get; private set; }
        public Email Email { get; private set; }
    }
}