using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;

// See https://aka.ms/new-console-template for more information

SPFarm farm = SPFarm.Local;
Console.WriteLine($"Farm Id: {farm.Id} \nFarm Name: {farm.Name} \nFarm Status: {farm.Status} \n");
Console.ReadKey();

Console.WriteLine("Hello, World!");
