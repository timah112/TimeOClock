using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeOClock.ClockStates
 {
    class ClockOutStates : State
    {
        ClockInStates clockInState = new ClockInStates();
        FormDomain formDomain;
        public Boolean isButtonEnabled = false;
     
        public void action(Boolean isEnabled)
        {           
           this.isButtonEnabled = isEnabled;     
        }
    }
}

