using Microsoft.SharePoint;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;
using System;
using System.Security.Permissions;

namespace _10EventReceiver.ListEventReceiver
{
  /// <summary>
  /// List Events
  /// </summary>
  public class ListEventReceiver : SPListEventReceiver
  {
    /// <summary>
    /// A field is being removed.
    /// </summary>
    public override void FieldDeleting(SPListEventProperties properties)
    {
      if (properties.FieldName.ToUpper().Equals("PRICE"))
      {
        properties.Status = SPEventReceiverStatus.CancelWithError;
        properties.ErrorMessage = "You can't delete PRICE column...";
      }
    }


  }
}