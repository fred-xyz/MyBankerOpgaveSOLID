using System;
using System.Collections.Generic;
using System.Text;

namespace MyBankerOpgaveSOLID
{
    public class Kredit : Card
    {
        public Kredit(int age_, int cardNumber_, string name_, int cradCode_, double accountAmount_) : base(age_, cardNumber_, name_, cradCode_, accountAmount_)
        {

        }

        // chack expirei date
        //THIS WILL BE A INTERFACE

        // chack age
        //THIS WILL BE A INTERFACE
    }
}
