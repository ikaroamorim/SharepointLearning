using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;

namespace _04SOMCoreCollections
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Listing all Farm Solutions:"); 
      foreach (SPSolution solution in SPFarm.Local.Solutions)
      {
        Console.WriteLine($"Solution Name: {solution.Name}  Status: {solution.Status}  ID: {solution.Id}");
      }
      Console.ReadKey();

      Console.WriteLine("Listing Farm Server:");
      SPFarm farm = SPFarm.Local;
      Console.WriteLine($"Farm Name:{farm.Name} Farm Type: {farm.TypeName} Status: {farm.Status}");
      Console.ReadKey();

      Console.WriteLine("Listing all Services in farm");
      foreach(SPService service in farm.Services)
      {
        Console.WriteLine($"\nService Name: {service.Name} \n Status: {service.Status}");
        if(service is SPWebService)
        {
          SPWebService currentWebService = service as SPWebService;

          foreach (SPWebApplication webApplication in currentWebService.WebApplications)
          {
            Console.WriteLine($"--Web Application: {webApplication.DisplayName} constains:");

            foreach (SPSite sitecollection in webApplication.Sites)
            {
              if (!sitecollection.Url.Contains("sitemaster"))
              {
                Console.WriteLine($"----Site: {sitecollection.Url} constains:");

                foreach (SPWeb web in sitecollection.AllWebs)
                {
                  Console.WriteLine($"------Web:{web.Title} Url: {web.Url} contains {web.Lists.Count.ToString()}");
                }
              }
            }
          }
        }
      }
      Console.ReadKey();




      Console.WriteLine("\nListing all webs from a Site:");
      SPSite site = new SPSite("http://server-quarto:1010/sites/Training");
      foreach (SPWeb web in site.AllWebs)
      {
        Console.WriteLine($"\nTitle: {web.Title} \t Url: {web.Url} \t Number of lists: {web.Lists.Count}");

        foreach (SPList list in web.Lists)
        {
          Console.WriteLine($"\nTitle: {list.Title} \nNumber of Items: {list.ItemCount} \nAuthor: {list.Author} \nDescription: {list.Description}");
        }
      }
    }
  }
}
