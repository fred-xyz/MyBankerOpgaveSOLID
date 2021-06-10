using System;
using System.Collections.Generic;
using System.Text;

namespace MyBankerOpgaveSOLID
{
    public interface IExpiryDate
    {
        void SetExpiryDate(int months);
        DateTime DateIsExpired { get; set; }

    }




}
