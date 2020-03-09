using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class BoletoPayment : Payment
    {
        public BoletoPayment(
            string barCode, 
            string boletoNumber,
            DateTime paidDate,
             DateTime expirateDate, 
             decimal tital, 
             decimal totalPaid, 
             string payer, 
             Document document, 
             Address address, 
             Email email) : base( paidDate,  expirateDate,  tital,  totalPaid,  payer,  document,  address,  email)
        {
            BarCode = barCode;
            BoletoNumber = boletoNumber;
        }

        public string BarCode { get; private set; }
        public string BoletoNumber { get; private set; }     
    }
}