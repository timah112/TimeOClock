using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeOClock.ClockStates
{
    interface State
    {
        void action(Boolean enable);
    }
}
