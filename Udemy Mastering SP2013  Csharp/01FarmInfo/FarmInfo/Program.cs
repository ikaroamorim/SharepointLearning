using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;

namespace FarmInfo
{
  internal class Program
  {
    static void Main(string[] args)
    {
      SPFarm farm = SPFarm.Local;
      Console.WriteLine($"Farm Id: {farm.Id} \nFarm Name: {farm.Name} \nFarm Status: {farm.Status} \n");
      Console.ReadKey();
    }
  }
}
