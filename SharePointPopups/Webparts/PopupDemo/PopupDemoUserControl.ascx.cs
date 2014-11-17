using System;
using System.Web.UI;
using SharePointPopups.Common;

namespace SharePointPopups.Webparts.PopupDemo
{
    /// <summary>
    /// Popup Demo User Control
    /// </summary>
    public partial class PopupDemoUserControl : UserControl
    {
        public string Url = string.Empty;

        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the OnClick event of the OKPopupButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void OKPopupButton_OnClick(object sender, EventArgs e)
        {
            Page.ClientScript.RegisterStartupScript(typeof (Page), "Popout Script",
                PopupOperations.ShowPopup(Constants.PopupType.Information,
                    "Information Message",
                    "This is a popup with OK Button. Clicking OK Will refresh the page.",
                    Constants.PopupButtons.Ok,
                    500, 210, true)
                , true);
        }

        /// <summary>
        /// Handles the OnClick event of the CancelPopupButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void CancelPopupButton_OnClick(object sender, EventArgs e)
        {
            Page.ClientScript.RegisterStartupScript(typeof (Page), "Popout Script",
                PopupOperations.ShowPopup(Constants.PopupType.Warning,
                    "Warning Message",
                    "This is a popup with OK and Cancel Buttons. Clicking OK Will refresh the page. Clicking Cancel will close this dialog.",
                    Constants.PopupButtons.OkCancel,
                    500, 210, true)
                , true);
        }

        /// <summary>
        /// Handles the OnClick event of the OKRedirectPopupButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void OKRedirectPopupButton_OnClick(object sender, EventArgs e)
        {
            Page.ClientScript.RegisterStartupScript(typeof (Page), "Popout Script",
                PopupOperations.ShowPopupAndRedirect(Constants.PopupType.Error,
                    "Error Message",
                    "This is a popup with OK Button. Clicking OK will redirect to the settings page.",
                    Constants.PopupButtons.Ok,
                    500, 210,
                    "/_layouts/15/settings.aspx")
                , true);
        }

        /// <summary>
        /// Handles the OnClick event of the CancelRedirectPopupButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void CancelRedirectPopupButton_OnClick(object sender, EventArgs e)
        {
            Page.ClientScript.RegisterStartupScript(typeof (Page), "Popout Script",
                PopupOperations.ShowPopupAndRedirect(Constants.PopupType.Information,
                    "Information Message",
                    "This is a popup with OK and Cancel Buttons. Clicking OK Will refresh the page. Clicking Cancel will close this dialog.",
                    Constants.PopupButtons.OkCancel,
                    500, 210,
                    "/_layouts/15/settings.aspx")
                , true);
        }
    }
}