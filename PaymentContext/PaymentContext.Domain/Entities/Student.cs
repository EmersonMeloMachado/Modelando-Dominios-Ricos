using System.Linq;
using System.Collections.Generic;
using PaymentContext.Domain.Entities;
using PaymentContext.Shared.Entities;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
        private IList<Subscription> _subcription;
        public Student(Name name,Document document,Email email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subcription = new List<Subscription>();
        }
        public Name Name { get; private set;}
        public Document Document { get; private set;}
        public Email Email { get; private set;}
        public Address Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscription { get; private set;}

        public void AddSubscription(Subscription subscription)
        {
            // Se já tiver uma assinatuda ativa ,cancela

            //Cancelar todas as outras assinaturas, e coloca com principal.
            foreach(var sub in Subscription)
            {
                sub.Inactivate();
            }

            _subcription.Add(subscription);
        }
    }
}