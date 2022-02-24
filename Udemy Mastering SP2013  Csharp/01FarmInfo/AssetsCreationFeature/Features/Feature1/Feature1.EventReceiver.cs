using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace AssetsCreationFeature.Features.Feature1
{
  /// <summary>
  /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
  /// </summary>
  /// <remarks>
  /// The GUID attached to this class may be used during packaging and should not be modified.
  /// </remarks>

  [Guid("77526660-109e-4ad5-b5b8-83114255a617")]
  public class Feature1EventReceiver : SPFeatureReceiver
  {
    // Uncomment the method below to handle the event raised after a feature has been activated.

    public override void FeatureActivated(SPFeatureReceiverProperties properties)
    {
      SPWebApplication webapp = properties.Feature.Parent as SPWebApplication;
      SPSiteCollection sitecol = webapp.Sites;

      if( sitecol["/sites/DeveloperTraining"] == null)
      {
        SPSite siteDeveloper = sitecol.Add("/sites/DeveloperTraining", "Developer Training Site", "Some Description", 1033, SPWebTemplate.WebTemplateSTS, @"IKARO\Administrator", "Ikaro Amorim e Silva", "ikaro.silva@ikarodeveloper.com");
      }

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
