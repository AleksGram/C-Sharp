using System;
using System.Collections.Generic;


namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            var honda = new Car("Honda civic");
            var tripConsumptions  = new List<double> () {9.5, 11.5, 12.1, 6.8, 13.2};
            honda.AddConsumption(tripConsumptions);

            Console.WriteLine($"Avarage consumption of {honda.getName()} is {honda.getAverageConsumption()} ");
            honda.showStatictic();
        }
    }
}
