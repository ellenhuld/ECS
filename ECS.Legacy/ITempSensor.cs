using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSLegacy
{
    public interface ITempSensor
    {
        int GetTemp();
        bool RunSelfTest();
    }
}
