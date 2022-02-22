using Microsoft.SharePoint;
using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace _09SharepointFeatures.Features.Feature3
{
  /// <summary>
  /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
  /// </summary>
  /// <remarks>
  /// The GUID attached to this class may be used during packaging and should not be modified.
  /// </remarks>

  [Guid("79fda6ef-79ac-4595-9172-6da4206691c7")]
  public class Feature3EventReceiver : SPFeatureReceiver
  {
    // Uncomment the method below to handle the event raised after a feature has been activated.

    public override void FeatureActivated(SPFeatureReceiverProperties properties)
    {
      SPWeb web = properties.Feature.Parent as SPWeb;

      web.Properties["ActualTitle"] = web.Title;
      web.Properties["ActualDescription"] = web.Description;
      web.Properties.Update();

      web.Title = "Title Modificado";
      web.Description = "Description Modificada";
      web.Update();
    }


    // Uncomment the method below to handle the event raised before a feature is deactivated.

    public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
    {
      SPWeb web = properties.Feature.Parent as SPWeb;

      web.Title = web.Properties["ActualTitle"];
      web.Description = web.Properties["ActualDescription"];

      web.Update();


    }


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
