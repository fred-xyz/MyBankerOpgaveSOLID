using MyBankerOpgaveSOLID;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBankerOpgaveSOLID
{
    public class Card : IExpiryDate
    {
        private int age;
        private int cardNumber;
        private string name;
        private int cradCode;
        private double accountAmount;
        private DateTime dateIsExpired;

        public int Age { get => age; set => age = value; }
        public int CardNumber { get => cardNumber; set => cardNumber = value; }
        public string Name { get => name; set => name = value; }
        public int CradCode { get => cradCode; set => cradCode = value; }
        public double AccountAmount { get => accountAmount; set => accountAmount = value; }

        //skal ind på de enkled kord
        public DateTime DateIsExpired { get => dateIsExpired; set => dateIsExpired = value; }

        public Card(int age_, int cardNumber_, string name_, int cradCode_, double accountAmount_)
        {
            this.age = age_;
            this.cardNumber = cardNumber_;
            this.name = name_;
            this.cradCode = cradCode_;
            this.accountAmount = accountAmount_;
        }
        //withdraw Money from an account
        public double WithdrawMoney()
        {
            double drawMoney = 100;
            Console.WriteLine("you account curen balens is: " + AccountAmount);
            if (drawMoney <= AccountAmount)
            {
                AccountAmount = -drawMoney;
                Console.WriteLine(drawMoney + " :will be withdraw");
                Console.Write("you bales is nave: ");
                return AccountAmount;
            }
            Console.WriteLine("you account curen balens is: ");
            return AccountAmount;
        }
        //skal inplemeter på vert kord
        public void SetExpiryDate(int months)
        {
            DateIsExpired = DateTime.Now.AddMonths(months);

            if (DateIsExpired == DateTime.Now)
            {
                Console.WriteLine("you card is to old. get a ned one.");
            }
        }
        // chack expirei date
        //THIS WILL BE A INTERFACE

        // chack age
        //THIS WILL BE A INTERFACE
    }
}
