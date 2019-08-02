using System;
using System.Collections.Generic;
using System.IO;

namespace Garage
{
  public class DiskCar :  IVehicle
  {
    public DiskCar(string name)
    {
      this.name = name;
    }

    public  void AddConsumption(List<double> tripConsumptions)
    {
      var writer = File.AppendText($"Consumption.txt");
        writer.WriteLine("c1 -- ");

      foreach (double consumption in tripConsumptions)
      {

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