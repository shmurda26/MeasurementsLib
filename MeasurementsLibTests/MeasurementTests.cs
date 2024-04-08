using Microsoft.VisualStudio.TestTools.UnitTesting;
using MeasurementsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasurementsLib.Tests
{
    [TestClass()]
    public class MeasurementTests
    {
        [TestMethod()]
        public void ToStringTest()
        {

        }

        [TestMethod()]
        public void ValidatePpmTest()
        {
            Measurement LowPpm = new()
            {
                Id = 69,
            
                
                Ppm = -69
            };
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                
                () => LowPpm.ValidatePpm());

            Measurement InRange = new()
            {
                
                Id = 420,
                
                Ppm = 420
            };
            InRange.ValidatePpm();

        }
    }
}