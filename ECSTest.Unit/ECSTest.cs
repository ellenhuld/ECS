using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ECS.Legacy;


namespace ECSTest.Unit
{
    [TestFixture]
    public class ECSTest
    {
        private TempSensor _uut;

        [SetUp]
        {
            _uut = new TempSensor();
        } 
    }
}
