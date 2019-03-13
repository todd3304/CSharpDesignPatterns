using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Observer
{
    public class Gearbox : ISpeedChange
    {
        public Gearbox(Speedometer speed)
        {
            speed.VChanged += ValueHasChanged;
        }

        public void ValueHasChanged(object sender, EventArgs args)
        {
            Speedometer mySpeedometer = (Speedometer)sender;

            if (mySpeedometer.CurrentSpeed <= 10)
            {
                Console.WriteLine("now in easy gear");
            }
            else if(mySpeedometer.CurrentSpeed <=20)
            {
                Console.WriteLine("now in second gear");
            }
            else if (mySpeedometer.CurrentSpeed <= 25)
            {
                Console.WriteLine("now in third gear");
            }
            else if (mySpeedometer.CurrentSpeed < 30)
            {
                Console.WriteLine("now in fourth gear");
            }
        }
    }
}
