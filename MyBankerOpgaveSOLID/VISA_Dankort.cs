using System;
using System.Collections.Generic;
using System.Text;

namespace MyBankerOpgaveSOLID
{
    public class VISA_Dankort : Kredit, IExpiryDate, IinternationaltNettet
    {
        public VISA_Dankort(int age_, int cardNumber_, string name_, int cradCode_, double accountAmount_) : base(age_, cardNumber_, name_, cradCode_, accountAmount_)
        {
            SetExpiryDate(60);
        }

        public bool InternationaltUse { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool NettetUse { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void chackInternationaltUse()
        {
            throw new NotImplementedException();
        }

        public void chackNettetUse()
        {
            throw new NotImplementedException();
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
