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
        public static PropertiesView GlobalPropertiesView;
        public static ShellWindow GlobalShell;
        public static StatusBarViewModel GlobalStatusBar;
        public static MainView MainView;
        public static RibbonView RibbonViewInstance;






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
