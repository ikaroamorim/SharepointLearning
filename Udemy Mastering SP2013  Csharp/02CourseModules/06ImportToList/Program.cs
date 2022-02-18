using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;

namespace _06ImportToList
{
  internal class Program
  {
    static void Main(string[] args)
    {
      SPSite site = new SPSite("http://server-quarto:1010/sites/Training");
      SPWeb web = site.OpenWeb();
      SPList list = web.Lists["ProductList1"];
      /*
      StreamReader sdr = new StreamReader(@"I:\repos\SharepointLearning\products.txt", Encoding.UTF8);
      SPListItem listItem = null;

      while (sdr.Peek() != -1)
      {
        listItem = list.Items.Add();
        listItem["Title"] = sdr.ReadLine();
        listItem["Price"] = sdr.ReadLine();
        listItem.Update();
      }
      */

      /*
      StreamReader sdr2 = new StreamReader(@"I:\repos\SharepointLearning\products.csv", Encoding.UTF8);
      listItem = null;
      string str;

      while (sdr2.Peek() != -1)
      {
        str = sdr2.ReadLine();
        string[] data = str.Split(',');

        listItem = list.Items.Add();
        listItem["Title"] = data[0];
        listItem["Price"] = data[1];
        listItem.Update();
      }
      */

      SPListItem listItem;
      SqlConnection cn = new SqlConnection("data source=.; initial catalog=DemoDatabase; integrated security=true;");
      SqlCommand cmd = new SqlCommand("SELECT * FROM products", cn);
      cn.Open();
      SqlDataReader sdr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

      while (sdr.Read())
      {
        listItem = list.Items.Add();
        listItem["Title"] = sdr["Title"];
        listItem["Price"] = sdr["Price"];
        listItem.Update();
      }
      sdr.Close();
      sdr.Dispose();



      Console.WriteLine("All records have been imported...");
      Console.ReadKey();

    }
  }
}
