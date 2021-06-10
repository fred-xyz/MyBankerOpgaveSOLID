using System;
using System.Collections.Generic;
using System.Text;

namespace MyBankerOpgaveSOLID
{
    public class Maestro : Debit, IExpiryDate, IchackAge
    {
        public Maestro(int age_, int cardNumber_, string name_, int cradCode_, double accountAmount_) : base(age_, cardNumber_, name_, cradCode_, accountAmount_)
        {
            SetExpiryDate(60);
        }

        public void chackAge()
        {
            int minAge = Age;
            if (minAge < 18)
            {
                Console.WriteLine("her you card:");
                Console.WriteLine(minAge);
            }
            Console.WriteLine("you a " + minAge + "you mith wand one of the orher card.");
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
