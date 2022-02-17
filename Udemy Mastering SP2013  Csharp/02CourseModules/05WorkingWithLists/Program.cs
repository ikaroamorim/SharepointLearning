using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;

namespace _05WorkingWithLists
{
  internal class Program
  {
    static void Main(string[] args)
    {
      SPSite site = new SPSite("http://server-quarto:1010/sites/Training");
      SPWeb web = site.OpenWeb();

      /*Scritp to check list exists and create
      Console.WriteLine("Digite o nome de lista:");
      string listName =  Console.ReadLine();
      Console.WriteLine(listName);

      
      SPList listCreatedByUser = null;
      if( !(web.Lists.TryGetList(listName) is SPList))
      {
        Guid listGuidUser = web.Lists.Add(listName, "Created from user input", SPListTemplateType.GenericList);

        listCreatedByUser = web.Lists[listGuidUser];
      }
      */

      /*Script to create list
      Guid listGuid = web.Lists.Add("Contacts List4", "Contacts List created through code", SPListTemplateType.Contacts);
      SPList list = web.Lists[listGuid];

      Console.WriteLine(list.Description);
      Console.WriteLine(listUser.Description);

      list.Description = "Contacts List created through code, and modified through code";
      list.Update();

      Console.WriteLine(list.Description);
      */

      /* Script to delete list
      SPList list1 = web.Lists["asdfasdfas"];
      list1.Delete();
      Console.WriteLine("Lista deletada.");
      */

      /* Script to create item through code
      SPListItem listItem = listCreatedByUser.Items.Add();
      listItem["Title"] = "Silva";
      listItem.Update();
      Console.WriteLine("item Criado.");
      */

      //Script for reading List Items
      SPList listToRead = web.Lists["TestList"];

      foreach(SPListItem item in listToRead.Items)
      {
        Console.WriteLine($" Title: {item["Title"]} Amount: {item["Amount"]}");
      }
      Console.ReadKey();
      //

      /*Script to reading queried items 
      SPQuery query = new SPQuery();
      query.Query = "<Where><Geq><FieldRef Name='_x0063_mt4'/> <Value Type='Number'>200</Value></Geq></Where>";

      SPListItemCollection queryedListItems = listToRead.GetItems(query);

      foreach (SPListItem item in queryedListItems)
      {
        Console.WriteLine($" Title: {item["Title"]} Amount: {item["Amount"]}");
      }
      Console.ReadKey();
      */

      /*Script to rename field
      SPField field = listToRead.Fields["Amount"];
      field.Title = "Cost";
      field.Update();
      Console.WriteLine("Campo amount renomeado");
      */
    }
  }
}
