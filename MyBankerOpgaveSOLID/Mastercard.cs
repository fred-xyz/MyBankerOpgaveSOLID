using System;
using System.Collections.Generic;
using System.Text;

namespace MyBankerOpgaveSOLID
{
    public class Mastercard : Kredit, IExpiryDate
    {
        public Mastercard(int age_, int cardNumber_, string name_, int cradCode_, double accountAmount_) : base(age_, cardNumber_, name_, cradCode_, accountAmount_)
        {
            SetExpiryDate(68);
        }
        // chack expirei date
        public new void SetExpiryDate(int months)
        {
            DateIsExpired = DateTime.Now.AddMonths(months);

            if (DateIsExpired == DateTime.Now)
            {
                Console.WriteLine("you card is to old. get a ned one.");
            }
        }

        // chack age
        //THIS WILL BE A INTERFACE
    }
}
