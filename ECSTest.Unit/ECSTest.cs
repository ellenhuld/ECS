using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ECSLegacy;


namespace ECSTest.Unit
{
    [TestFixture]
    public class ECSTest
    {
        private ECS _uut;
        private FakeTempSensor _fakeTempSensor;
        private FakeHeater _fakeHeater;

        [SetUp]
        public void Setup()
        {

            _fakeTempSensor = new FakeTempSensor();
            _fakeHeater = new FakeHeater();
            _uut = new ECS(20,_fakeHeater,_fakeTempSensor);
        } 

        //[Test]



    }
}
