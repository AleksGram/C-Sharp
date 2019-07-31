using System;
using System.Collections.Generic;

namespace Garage 
{
    public class Car
    {   
        public Car(string name)
        {
            this.consumptionsStore = new List<double>(); 
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public void AddConsumption(List<double> tripConsumptions)
        {   
            foreach (double consumption in tripConsumptions) 
            {
                this.consumptionsStore.Add(consumption);
            }
        }
        
        public double getAverageConsumption()
        {
            var result = 0.0;
            if (this.consumptionsStore.Count > 0)
            {
                foreach (double consumption in this.consumptionsStore)
                {
                    result += consumption;
                }
                return result/this.consumptionsStore.Count;
            } else {
                return 0.0;
            }
        }

        public void showStatictic()
        {
            var highConsumption = double.MinValue;
            var lowConsumption = double.MaxValue;

            foreach (double consumption in this.consumptionsStore)
            {
                highConsumption = Math.Max(consumption, highConsumption);
                lowConsumption = Math.Min(consumption, lowConsumption);
            }
            Console.WriteLine($"Max consumption in trip {highConsumption} l/100");
            Console.WriteLine($"Min consumption in trip {lowConsumption} l/100");
        }

        private string name;
        private List<double> consumptionsStore;

    }
}