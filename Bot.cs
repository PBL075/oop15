using System;

namespace testsss
{
    class Bot : IRun
    {
        public int speed {get; set;}= 100;

        public void CarRun()
        {
            Console.WriteLine("Marca BMW merge cu "+ speed + " km/h");
        }

    }
}