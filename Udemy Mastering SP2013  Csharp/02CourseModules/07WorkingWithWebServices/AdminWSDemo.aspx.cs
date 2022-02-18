using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminWSDemo : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
  {

  }

  protected void Button2_Click(object sender, EventArgs e)
  {
    //Delete Site
    SPAdminWSProxy.Admin admin = new SPAdminWSProxy.Admin();
    admin.Credentials = System.Net.CredentialCache.DefaultCredentials;
    admin.DeleteSite("http://server-quarto:1010/sites/Products2");
    Label1.Text = "<h2>Site Collection has been deleted</h2>";

  }

  protected void Button1_Click(object sender, EventArgs e)
  {
    try
    {
      //Create Site
      SPAdminWSProxy.Admin admin = new SPAdminWSProxy.Admin();
      admin.Credentials = System.Net.CredentialCache.DefaultCredentials;

      admin.CreateSite("http://server-quarto:1010/sites/Products2",
        "SiteWebServices1",
        "SiteWebServices1 Description",
        1033,
        "STS#0",
        "ikaro\\administrador",
        "Administrador",
        "Administrador@ikarodeveloper.com",
        "",
        "");

      Label1.Text = "<h2>Site Collection has been created </h2>";
    }
    catch (System.Web.Services.Protocols.SoapException ex)
    {
      Console.WriteLine(ex.ToString());
    }
  }
}