namespace SharePointPopups.Common
{
    /// <summary>
    /// Popup Operations
    /// </summary>
    public static class PopupOperations
    {
        /// <summary>
        /// Shows the popup.
        /// </summary>
        /// <param name="messageType">Type of the message.</param>
        /// <param name="title">The title.</param>
        /// <param name="message">The message.</param>
        /// <param name="buttons">The buttons.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="refreshPage">if set to <c>true</c> [refresh page].</param>
        /// <returns></returns>
        public static string ShowPopup(Constants.PopupType messageType, string title, string message,
            Constants.PopupButtons buttons, int width, int height, bool refreshPage)
        {
            const string pageUrlFormat = "{0}?Type={1}&Title={2}&Message={3}&Options={4}&isDlg=1";
            const string dialogStringFormat = "openInDialog({0}, {1}, false, true, {2},'{3}');";

            string pageUrl = string.Format(pageUrlFormat, Constants.ShowMessagePage, messageType, title, message,
                buttons);
            string dialogString = string.Format(dialogStringFormat, width, height, refreshPage.ToString().ToLower(),
                pageUrl);

            return dialogString;
        }

        /// <summary>
        /// Shows the popup and redirect.
        /// </summary>
        /// <param name="messageType">Type of the message.</param>
        /// <param name="title">The title.</param>
        /// <param name="message">The message.</param>
        /// <param name="buttons">The buttons.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="redirectUrl">The redirect URL.</param>
        /// <returns></returns>
        public static string ShowPopupAndRedirect(Constants.PopupType messageType, string title, string message,
            Constants.PopupButtons buttons, int width, int height, string redirectUrl)
        {
            const string pageUrlFormat = "{0}?Type={1}&Title={2}&Message={3}&Options={4}&isDlg=1";
            const string dialogStringFormat = "openInDialogAndRedirect({0}, {1}, false, true, '{2}','{3}');";

            string pageUrl = string.Format(pageUrlFormat, Constants.ShowMessagePage, messageType, title, message,
                buttons);
            string dialogString = string.Format(dialogStringFormat, width, height, pageUrl, redirectUrl);

            return dialogString;
        }
    }
}