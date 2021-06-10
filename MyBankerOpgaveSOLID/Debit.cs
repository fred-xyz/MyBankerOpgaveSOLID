using System;
using System.Collections.Generic;
using System.Text;

namespace MyBankerOpgaveSOLID
{
    public class Debit : Card
    {
        public Debit(int age_, int cardNumber_, string name_, int cradCode_, double accountAmount_) : base(age_, cardNumber_, name_, cradCode_, accountAmount_)
        {

        }
    }
}
