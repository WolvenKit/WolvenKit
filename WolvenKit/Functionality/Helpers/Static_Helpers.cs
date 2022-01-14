using Octokit;

namespace WolvenKit.Functionality.Helpers
{
    public static class StaticReferences
    {
        //public static PropertiesView GlobalPropertiesView { get; set; }
        //public static RibbonView RibbonViewInstance { get; set; }
        //public static StatusBarViewModel GlobalStatusBar { get; set; }
        //public static MainView MainView { get; set; }

        public static HandyControl.Controls.GlowWindow XoWindow;

        public static bool ShowGuidedTour { get; set; } = false;

        public static bool AllowVideoPreview { get; set; } = true;

        public static bool IsWebView2Enabled { get; set; } = false;

        /// <summary>
        /// Clean settings below this text.
        /// </summary>

        // Github Client
        public static GitHubClient Githubclient;

    }
}
