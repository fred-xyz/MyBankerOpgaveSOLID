using System;
using System.Collections.Generic;
using System.Text;

namespace MyBankerOpgaveSOLID
{
    public class CashCard : Debit, IchackAge
    {
        private int aggOfCardOwnder;
        public int AggOfCardOwnder { get => aggOfCardOwnder; set => aggOfCardOwnder = value; }
        public CashCard(int age_, int cardNumber_, string name_, int cradCode_, double accountAmount_, int aggOfCardOwnder_) : base(age_, cardNumber_, name_, cradCode_, accountAmount_)
        {
            this.aggOfCardOwnder = aggOfCardOwnder_;
        }

        //CHECk THA THE CRAD OWNER IS OER 18
        //ask if this shout be a interface aswell
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
        //this cord dons not have a expirei date

        // chack age
        //THIS WILL BE A INTERFACE

    }
}
