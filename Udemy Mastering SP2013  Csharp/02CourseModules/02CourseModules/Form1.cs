using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint.Navigation;

namespace _02CourseModules
{
  public partial class Form1 : Form
  {
    protected string Message;

    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      SPSite site = new SPSite("http://server-quarto:1010/sites/Training");
      SPWeb web = site.OpenWeb();
      SPWebCollection subsites = web.Webs;
      SPWeb newWeb = subsites.Add("CustomerSupport", "Customer Support Site", "Customer Support Site Description", 1033, "STS#0", false, false);
      MessageBox.Show($"O novo site foi criado {newWeb.Url}");

      //site.AllWebs
    }

    private void button2_Click(object sender, EventArgs e)
    {
      SPSite site = new SPSite("http://server-quarto:1010/sites/Training");
      SPWeb web = site.AllWebs["CustomerSupport"];
      SPNavigationNode node = new SPNavigationNode(LinkTitle.Text, LinkUrl.Text, true);

      web.Navigation.QuickLaunch.AddAsLast(node);
      web.Navigation.TopNavigationBar.AddAsLast(node);

      MessageBox.Show("The node have been added...");
      LinkTitle.Clear();
      LinkUrl.Clear();
    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void createList_Click(object sender, EventArgs e)
    {
      SPSite site = new SPSite("http://server-quarto:1010/sites/Training");
      SPWeb web = site.AllWebs["CustomerSupport"];

      Guid newGuid = web.Lists.Add( listNameBox.Text ,  "All Customers Supported List", SPListTemplateType.GenericList);
      SPList list = web.Lists[newGuid];

      list.Fields.Add("FirstName", SPFieldType.Text, true);
      list.Fields.Add("LastName", SPFieldType.Text, true);
      list.Fields.Add("Country", SPFieldType.Text, true);

      StringCollection viewFields = new StringCollection();

      viewFields.Add("FirstName");
      viewFields.Add("LastName");
      viewFields.Add("Country");

      string query = "<Where><Eq><FieldRef Name=\"Country\" /> <Value Type=\"Text\">Brazil</Value></Eq></Where>";

      list.Views.Add("Brazil View", viewFields, query, 100, true, true);

      MessageBox.Show("Done");

    }
  }
}
