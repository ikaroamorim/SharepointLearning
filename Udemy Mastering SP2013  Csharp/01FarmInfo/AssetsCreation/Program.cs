using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;

namespace AssetsCreation
{
  internal class Program
  {
    static void Main(string[] args)
    {

      /***
       *
       *  Creation of a Site in already created Web Application
       * 
      SPSite site = new SPSite("https://server-quarto/");
      SPWebApplication webapp = site.WebApplication;

      webapp.Sites.Add("/sites/Training",
        "Training Site",
        "Training Udemy CSOM Sharepoint",
        1033, 
        "STS#0",
        @"IKARO\Administrator",
        "Administrator",
        "Administrator@ikarodeveloper.com");

      */


      /***
       *  Creations of Web in our recently created Site 
       *  
      SPSite site = new SPSite("https://server-quarto/sites/Training");
      SPWeb web = site.AllWebs.Add("BrandNewBlogSite", "Blog Site", "Some Description", 1033, "BLOG#0", false, false);

      Console.WriteLine("Blog site has been Created");
      */

      Console.ReadKey();
    }
  }
}
