using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECSLegacy;

namespace ECSTest.Unit
{
    public class FakeTempSensor : ITempSensor
    {
        public int _temp { get; set; }
        public int GetTemp()
        {
            return _temp;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
