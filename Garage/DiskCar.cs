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

    public  List<double> AddConsumption(List<double> tripConsumptions)
    {


      foreach (double consumption in tripConsumptions)
      {
        using (var writer = File.AppendText($"Consumption.txt"))
        {
          writer.WriteLine($"c1 -- {consumption.ToString()}");
        }
      }
      return tripConsumptions;

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