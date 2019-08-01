using System;
using System.Collections.Generic;
using System.IO;

namespace Garage
{
  public class DiskCar : Vehicle, IVehicle
  {
    public DiskCar(string name)
    {
      this.name = name;
    }

    public override void AddConsumption(List<double> tripConsumptions)
    {
      var writer = File.AppendText($"Consumption.txt");

      foreach (double consumption in tripConsumptions)
      {

        writer.WriteLine(consumption);
      }

    }
    public void WriteInfo(string s)
    {
      using(var writer = File.AppendText($"Info.txt"))
      {
        writer.WriteLine(s);
      }
    }
    public event ConsumptionAddedDelegate ConsumptionAdded;

    public string getName()
    {
      return this.name;
    }

    public void showStatictic()
    {

    }
    private string name;

  }
}