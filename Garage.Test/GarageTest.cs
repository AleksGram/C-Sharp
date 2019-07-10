using System;
using System.Collections.Generic;
using Xunit;

namespace Garage.Test {
    
    public class GarageTest {
        [Fact]
        public void Test1 () {

            var honda = new Car ("Honda civic");
            var tripConsumption = new List<double> () { 12.2, 10.5, 6.8, 10.3 };
            honda.AddConsumption (tripConsumption);
            honda.getAverageConsumption ();

            var util = new CalcUtils();
            var expRes = util.calcAverageValue (tripConsumption);

            Assert.Equal (honda.getAverageConsumption (), expRes);

        }
    }
}