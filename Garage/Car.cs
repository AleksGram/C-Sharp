using System;
using System.Collections.Generic;

namespace Garage 
{
    public delegate void ConsumptionAddedDelegate(Object sender , EventArgs args);

    public interface IVehicle
    {
        void AddConsumption(List<double> consumptions);
        event ConsumptionAddedDelegate ConsumptionAdded;
        void showStatictic();
    }

    public abstract class Vehicle
    {
        public abstract void AddConsumption(List<double> tripConsumptions);
    }

    public class InMemoryCar : Vehicle, IVehicle
    {   
        public delegate string TestDelegate(string message);
        public InMemoryCar(string name)
        {
            this.consumptionsStore = new List<double>(); 
            this.name = name;
        }

        public string GetTestMessage(string name)
        {
            Console.WriteLine($"Delegate GetTestMessage name {name} ");

            return name;
        }

        public string LogTestMessage (string name)
        {
             Console.WriteLine($"Delegate LogTestMessage name {name} ");
             return name;
        }
        public string getName()
        {
            return this.name;
        }

        public override void  AddConsumption(List<double> tripConsumptions)
        {   
            foreach (double consumption in tripConsumptions) 
            {
                this.consumptionsStore.Add(consumption);
                if (this.ConsumptionAdded != null)
                {
                    this.ConsumptionAdded(this, new EventArgs());
                }
            }
        }

        public event  ConsumptionAddedDelegate ConsumptionAdded;
        
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

            // Testing delegate
            TestDelegate logger = GetTestMessage;
            logger += LogTestMessage;
            logger(this.name);

            Console.WriteLine($"Max consumption in trip {highConsumption} l/100");
            Console.WriteLine($"Min consumption in trip {lowConsumption} l/100");
        }

        private string name;
        private List<double> consumptionsStore;

    }
}