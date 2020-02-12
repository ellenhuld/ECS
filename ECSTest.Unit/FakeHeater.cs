using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECSLegacy;

namespace ECSTest.Unit
{
    public class FakeHeater : IHeater
    {
        public int TurnOnCalled { get; set;}

        public void TurnOn()
        {
            TurnOnCalled++;
        }

        

        public void TurnOff()
        {
            System.Console.WriteLine("Heater is off");
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
