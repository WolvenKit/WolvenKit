using System.Windows.Media;
using Octokit;

namespace WolvenKit.Functionality.WKitGlobal.Helpers
{
    public static class Initializations
    {
        public static void InitializeThemeHelper()
        {
            HandyControl.Themes.ThemeManager.Current.SetCurrentValue(HandyControl.Themes.ThemeManager.ApplicationThemeProperty, HandyControl.Themes.ApplicationTheme.Dark);
            var tr = new HandyControl.Themes.ThemeResources
            {
                AccentColor = HandyControl.Tools.ResourceHelper.GetResource<Brush>("MahApps.Brushes.Accent3")
            };
        }

        public static async void InitializeGitHub()
        {
            GithubHelper.GhubClient = new GitHubClient(new ProductHeaderValue("WolvenKit"))
            {
                Credentials = GithubHelper.GhubAuth("wolvenbot", "botwolven1")
            };
            await GithubHelper.GhubLastReleaseAsync();
        }

    }
}
