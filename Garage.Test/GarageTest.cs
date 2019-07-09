using System;
using System.Collections.Generic;
using Xunit;

namespace Garage.Test
{
    public class GarageTest
    {
        [Fact]
        public void Test1()
        {
            
            var honda = new Car("Honda civic");
            var tripConsumption  = new List<double>() {12.2, 10.5, 6.8, 10.3};
            honda.AddConsumption(tripConsumption);
            honda.getAverageConsumption();
            Assert.Equal(honda.getAverageConsumption(), (12.2 + 10.5 + 6.8 + 10.3)/4);

        }
    }
}
