using System;
using System.Collections.Generic;
using System.Text;

namespace MyBankerOpgaveSOLID
{
    public interface IinternationaltNettet
    {
        bool InternationaltUse { get; set; }
        bool NettetUse { get; set; }
        void chackInternationaltUse();
        void chackNettetUse();

    }
}
