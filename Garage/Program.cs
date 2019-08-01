using System;
using System.Collections.Generic;
using System.Globalization;


namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            var tripConsumptions = new List<double>();
            Console.WriteLine("Please type your car");
            var name = Console.ReadLine();

            var car = new InMemoryCar(name);
            car.ConsumptionAdded += OnConsumptionAdded;
            Console.WriteLine("Please type your consumption data using ' , ' between");
            var consumptionString = Console.ReadLine();

            IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };

           string[] consumptionData = consumptionString.Split(',');
           foreach (string s in consumptionData)
           {
               try 
               {
                   double d = double.Parse(s, formatter);
                   tripConsumptions.Add(d);
               }
               catch(Exception ex)
               {
                   Console.WriteLine(ex.Message);
                   throw;

               } 
           }

            car.AddConsumption(tripConsumptions);

            Console.WriteLine($"Avarage consumption of {car.getName()} is {car.getAverageConsumption()} ");
            car.showStatictic();
            
        }
        static void OnConsumptionAdded(object sender, EventArgs e)
        {
            Console.WriteLine($"Consumption was added");
        }
    }
}
