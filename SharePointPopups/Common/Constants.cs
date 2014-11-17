namespace SharePointPopups.Common
{
    /// <summary>
    /// Defines the constants.
    /// </summary>
    public static class Constants
    {
        public enum PopupButtons
        {
            Ok,
            OkCancel
        }

        public enum PopupType
        {
            Information,
            Warning,
            Error
        }

        public const string ErrorImage = "/Style%20Library/Custom%20Images/Error.png";
        public const string WarnImage = "/Style%20Library/Custom%20Images/Warn.png";
        public const string InfoImage = "/Style%20Library/Custom%20Images/Info.png";

        public const string MessageTitleQueryName = "Title";
        public const string MessageContentQueryName = "Message";
        public const string MessageTypeQueryName = "Type";
        public const string MessageOptionsQueryName = "Options";

        public const string ShowMessagePage = "/_layouts/15/SharePointPopups/ShowMessage.aspx";
    }
}