using System;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;

namespace FarmDemo
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      SPFarm farm = SPFarm.Local;
      Console.WriteLine("Farm Id:  {0} Name: {1} Status: {2}", farm.Id, farm.Name, farm.Status);
      Console.ReadKey();
    }
  }
}
