using System;

namespace testsss
{
    class Killer : IRun
    {
        public int speed {get; set;} = 134;
        public void CarRun()
        {
            Console.WriteLine("Mercedesul merge cu "+ speed + " km/h");        
        }
    }
}