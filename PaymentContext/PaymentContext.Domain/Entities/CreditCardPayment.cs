using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(
            string cadHolderName, 
            string cardNumber, 
            string lastTransactionNumber,
            DateTime paidDate, 
            DateTime expirateDate, 
            decimal tital, 
            decimal totalPaid, 
            string payer, 
            Document document, Address address, Email email) : base( paidDate,  expirateDate,  tital,  totalPaid,  payer,  document,  address,  email)
        {
            CadHolderName = cadHolderName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CadHolderName { get; private set; }
        public string CardNumber { get; private set; }  
        public string LastTransactionNumber { get; private set; }
    }
}