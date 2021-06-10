using System;
using System.Collections.Generic;
using System.Text;

namespace MyBankerOpgaveSOLID
{
    public interface Ikredit
    {
        double KreditOnCard { get; set; }
        double MaxKredit { get; set; }
        void chackKredit();
        void chackMaxKredit();

    }
}
