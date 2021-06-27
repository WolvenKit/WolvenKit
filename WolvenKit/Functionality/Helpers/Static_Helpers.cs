using Catel.Logging;
using Octokit;
using Orchestra.Views;
using WolvenKit.ViewModels.Shell;
using WolvenKit.Views.Editor;
using WolvenKit.Views.Shell;

namespace WolvenKit.Functionality.Helpers
{
    public static class StaticReferences
    {
        public static PropertiesView GlobalPropertiesView { get; set; }
        public static ShellWindow GlobalShell { get; set; }
        public static RibbonView RibbonViewInstance { get; set; }
        public static StatusBarViewModel GlobalStatusBar { get; set; }
        public static MainView MainView { get; set; }


        public static HandyControl.Controls.GlowWindow XoWindow;




        public static bool ShowGuidedTour { get; set; } = false;






        /// <summary>
        /// Clean settings below this text.
        /// </summary>


        // Github Client
        public static GitHubClient Githubclient;

        // Global Logger.
        public static readonly ILog Logger = LogManager.GetCurrentClassLogger();

    }
}
