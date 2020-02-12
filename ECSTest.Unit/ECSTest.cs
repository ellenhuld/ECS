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
        private FakeTempSensor _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new FakeTempSensor();
        } 
    }
}
