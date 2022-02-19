using Microsoft.SharePoint;
using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace _08SharepointArtifacts.Features.Feature1
{
  /// <summary>
  /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
  /// </summary>
  /// <remarks>
  /// The GUID attached to this class may be used during packaging and should not be modified.
  /// </remarks>

  [Guid("0b61132b-b9c5-4a74-9ded-8609a82597fa")]
  public class Feature1EventReceiver : SPFeatureReceiver
  {
    // Uncomment the method below to handle the event raised after a feature has been activated.

    public override void FeatureActivated(SPFeatureReceiverProperties properties)
    {
      SPSite parentSite = properties.Feature.Parent as SPSite;

      SPWeb parentWeb = parentSite.OpenWeb();

      SPList trainersList = parentWeb.Lists["MicrosoftCertifiedTrainers"];

      SPField fullNameField = trainersList.Fields["Full Name"];
      SPField emailAddressField = trainersList.Fields["Email Address"];

      fullNameField.Required = true;
      emailAddressField.Required = true;

      fullNameField.Indexed = true;
      emailAddressField.Indexed = true;

      fullNameField.Update();
      emailAddressField.Update();

      SPView mctDefaultView = trainersList.DefaultView;
      mctDefaultView.ViewFields.Delete("Attachments");

      SPList studentsList = parentWeb.Lists["Students"];
      SPFieldCollection studentsFields = studentsList.Fields;

      SPField titleField = studentsFields["Title"];
      titleField.Title = "StudentID";
      titleField.Indexed = true;
      titleField.Update();

      studentsFields.Add("FirstName", SPFieldType.Text, true);
      studentsFields.Add("LastName", SPFieldType.Text, true);
      studentsFields.Add("EmailAddress", SPFieldType.Text, true);
      studentsFields.Add("Phone Number", SPFieldType.Text, false);
      studentsFields.Add("User", SPFieldType.User, true);

      studentsFields["EmailAddress"].Title = "Email Address";

      studentsList.Update();

      SPView studentsDefaultView = studentsList.DefaultView;
      studentsDefaultView.ViewFields.Add("FirstName");
      studentsDefaultView.ViewFields.Add("LastName");
      studentsDefaultView.ViewFields.Add("EmailAddress");
      studentsDefaultView.ViewFields.Add("Phone Number");
      studentsDefaultView.ViewFields.Add("User");
      studentsDefaultView.Update();





    }


    // Uncomment the method below to handle the event raised before a feature is deactivated.

    //public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
    //{
    //}


    // Uncomment the method below to handle the event raised after a feature has been installed.

    //public override void FeatureInstalled(SPFeatureReceiverProperties properties)
    //{
    //}


    // Uncomment the method below to handle the event raised before a feature is uninstalled.

    //public override void FeatureUninstalling(SPFeatureReceiverProperties properties)
    //{
    //}

    // Uncomment the method below to handle the event raised when a feature is upgrading.

    //public override void FeatureUpgrading(SPFeatureReceiverProperties properties, string upgradeActionName, System.Collections.Generic.IDictionary<string, string> parameters)
    //{
    //}
  }
}
