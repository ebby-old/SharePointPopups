using System;
using System.Linq;
using Microsoft.SharePoint.WebControls;
using SharePointPopups.Common;

namespace SharePointPopups.Layouts.SharePointPopups
{
    /// <summary>
    /// Show Message Application Page
    /// </summary>
    public partial class ShowMessage : LayoutsPageBase
    {
        //Constants      
        public string MessageButtonOptions = string.Empty;
        public string MessageContentValue = string.Empty;
        public string MessageImageText = string.Empty;
        public string MessageImageValue = string.Empty;
        public string MessageTitleQueryValue = string.Empty;

        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.AllKeys.Contains(Constants.MessageContentQueryName))
            {
                MessageContentValue = Request.QueryString[Constants.MessageContentQueryName];
            }

            if (Request.QueryString.AllKeys.Contains(Constants.MessageTitleQueryName))
            {
                MessageTitleQueryValue = Request.QueryString[Constants.MessageTitleQueryName];
            }

            if (Request.QueryString.AllKeys.Contains(Constants.MessageTypeQueryName))
            {
                MessageImageText = Request.QueryString[Constants.MessageTypeQueryName];
                switch (Request.QueryString[Constants.MessageTypeQueryName].ToUpperInvariant())
                {
                    case "ERROR":
                        MessageImageValue = Constants.ErrorImage;
                        break;
                    case "WARNING":
                        MessageImageValue = Constants.WarnImage;
                        break;
                    case "INFORMATION":
                        MessageImageValue = Constants.InfoImage;
                        break;
                }
            }

            if (Request.QueryString.AllKeys.Contains(Constants.MessageOptionsQueryName))
            {
                MessageButtonOptions = Request.QueryString[Constants.MessageOptionsQueryName];
            }
        }

        /// <summary>
        /// Handles the OnClick event of the OkButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void OkButton_OnClick(object sender, EventArgs e)
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "PopupScript",
                "SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, 'OK');", true);
        }

        /// <summary>
        /// Handles the OnClick event of the CancelButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void CancelButton_OnClick(object sender, EventArgs e)
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "PopupScript",
                "SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.cancel, 'Cancel');", true);
        }
    }
}