using Microsoft.SharePoint;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;
using System;
using System.IO;
using System.Security.Permissions;
using System.Text;

namespace _10EventReceiver.ListItemEventReceiver
{
  /// <summary>
  /// List Item Events
  /// </summary>
  public class ListItemEventReceiver : SPItemEventReceiver
  {

    private void CheckEligibility(SPItemEventProperties properties)
    {
      int Hour = DateTime.Now.Hour;
      if (Hour < 15)
      {
        properties.Status = SPEventReceiverStatus.CancelWithError;
        properties.ErrorMessage = "No data manipulations are allowed before 3PM";
      }
    }

    private void LogOperations(SPItemEventProperties properties, string strEvent)
    {
      if (properties.ListTitle.ToUpper().Equals("PRODUCTS"))
      {
        FileIOPermission fp = new FileIOPermission(PermissionState.Unrestricted);
        fp.AddPathList(FileIOPermissionAccess.AllAccess, @"c:\Log");

        StreamWriter sw = File.AppendText(@"C:\Log\ListsLog.txt");
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("Date, Event and List : \n {0} {1} {2}", DateTime.Now.ToString(), strEvent, "PRODUCTS");
        sw.WriteLine(sb.ToString());
      }
    }

    /// <summary>
    /// An item is being added.
    /// </summary>
    public override void ItemAdding(SPItemEventProperties properties)
    {
      CheckEligibility(properties);
      base.ItemAdding(properties);
    }

    /// <summary>
    /// An item is being updated.
    /// </summary>
    public override void ItemUpdating(SPItemEventProperties properties)
    {
      CheckEligibility(properties);
    }

    /// <summary>
    /// An item is being deleted.
    /// </summary>
    public override void ItemDeleting(SPItemEventProperties properties)
    {
      CheckEligibility(properties);
    }

    /// <summary>
    /// An item was added.
    /// </summary>
    public override void ItemAdded(SPItemEventProperties properties)
    {
      LogOperations(properties, "Added");
    }

    /// <summary>
    /// An item was updated.
    /// </summary>
    public override void ItemUpdated(SPItemEventProperties properties)
    {
      LogOperations(properties, "Updated");
    }

    /// <summary>
    /// An item was deleted.
    /// </summary>
    public override void ItemDeleted(SPItemEventProperties properties)
    {
      LogOperations(properties, "Deleted");
    }
  }
}