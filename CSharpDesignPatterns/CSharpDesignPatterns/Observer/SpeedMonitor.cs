using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Observer
{
    public class SpeedMonitor : ISpeedChange
    {
        public const int SpeedToAlert = 30;

        public SpeedMonitor(Speedometer speed)
        {
            speed.VChanged += ValueHasChanged;
        }

        public void ValueHasChanged(object sender, EventArgs args)
        {
            Speedometer mySpeed = (Speedometer)sender;

            if (mySpeed.CurrentSpeed > SpeedToAlert)
            {
                Console.WriteLine("*** alert *** riding too fast *** (" + mySpeed.CurrentSpeed + ")" );
            }
            else
            {
                Console.WriteLine("*** nice and steady *** (" + mySpeed.CurrentSpeed + ")");
            }
        }
    }
}
