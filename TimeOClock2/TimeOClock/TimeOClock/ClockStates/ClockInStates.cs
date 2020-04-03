using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeOClock;
using System.Windows.Forms;

namespace TimeOClock.ClockStates
{
    
    class ClockInStates : State
    {        
        public Boolean isButtonEnabled = false;
     
        public void action(Boolean isEnabled)
        {           
           this.isButtonEnabled = isEnabled;     
        }
    }
}
