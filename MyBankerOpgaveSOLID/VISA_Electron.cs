using System;
using System.Collections.Generic;
using System.Text;

namespace MyBankerOpgaveSOLID
{
    public class VISA_Electron : Debit, IExpiryDate
    {
        //the max amount you can usen on a Month
        private double maxMonthlySpending = 10000;

        public double MaxMonthlySpending { get => maxMonthlySpending; set => maxMonthlySpending = value; }
        public VISA_Electron(int age_, int cardNumber_, string name_, int cradCode_, double accountAmount_) : base(age_, cardNumber_, name_, cradCode_, accountAmount_)
        {
            SetExpiryDate(60);

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
