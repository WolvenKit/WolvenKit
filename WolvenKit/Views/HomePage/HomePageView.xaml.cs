using Catel.IoC;
using HandyControl.Controls;
using HandyControl.Data;
using HandyControl.Tools;
using Octokit;
using Orchestra.Services;
using Orchestra.Views;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WolvenKit.ViewModels;
using WolvenKit.ViewModels.Wizards;
using WolvenKit.Views.AudioTool.Radio;
using WolvenKit.Views.HomePage.Pages;
using WolvenKit.Views.Wizards;

namespace WolvenKit.Views.HomePage
{
    public partial class HomePageView
    {



        private WelcomePageView WelcomePV;
        private FirstSetupWizardView FirstSWV;
        private RecentProjectView RecentPV;
        private ProjectWizardView ProjectWV;
        private WikiPageView WikitPV;
        private AboutPageView AboutPV;
        private SettingsPageView SettingsPV;
        private WebsitePageView WebsitePV;
        private UserPageView UserPV;
        private IntegratedToolsPageView IntegratedTPV;
        private GithubPageView GithubPV;


        public HomePageView()
        {
            InitializeComponent();
            InitializeGitHub();
            InitializePages();

        }

        private void InitializePages()
        {
            WelcomePV = new WelcomePageView();
            FirstSWV = new FirstSetupWizardView();
            RecentPV = new RecentProjectView();
            ProjectWV = new ProjectWizardView();
            ProjectWV.Loaded += (_s, _e) =>
                (ProjectWV.ViewModel as ProjectWizardViewModel).ClosingRequest
                    += (s, e) => SideMenu_WelcomeItem_Selected(s, new RoutedEventArgs());
            WikitPV = new WikiPageView();
            AboutPV = new AboutPageView();
            SettingsPV = new SettingsPageView();
            WebsitePV = new WebsitePageView();
            UserPV = new UserPageView();
            GithubPV = new GithubPageView();
            IntegratedTPV = new IntegratedToolsPageView();
        }

        private async void InitializeGitHub()
        {
            GhubClient = new GitHubClient(new ProductHeaderValue("WolvenKit"));
            GhubClient.Credentials = GhubAuth("wolvenbot", "botwolven1");
            await GhubLastReleaseAsync();
        }

        GitHubClient GhubClient;

        public Credentials GhubAuth(string u, string p)
        {

            var basicAuth = new Credentials(u, p); // NOTE: not real credentials
            return basicAuth;

        }

        public async Task GhubLastReleaseAsync()
        {

            try
            {
                var general = await GhubClient.Repository.Get("WolvenKit", "Wolven-Kit");
                var g_stars = general.StargazersCount;
                var g_forks = general.ForksCount;
#pragma warning disable 618
                var g_watchers = general.SubscribersCount;  // Ignore that error its the only way to get the watchers atm. (Shit documentation online tbh)
#pragma warning restore 618


                WatchShield.SetCurrentValue(Shield.StatusProperty, g_watchers.ToString());
                ForkShield.SetCurrentValue(Shield.StatusProperty, g_forks.ToString());
                StarShield.SetCurrentValue(Shield.StatusProperty, g_stars.ToString());






                var releases = await GhubClient.Repository.Release.GetLatest("WolvenKit", "Wolven-Kit");
                var latest = releases; // Just a temp fix so I don't spam GHub api during dev
                ObservableCollection<GithubTimeLine> data = new ObservableCollection<GithubTimeLine>();

                var item = new GithubTimeLine() { TitleLabel = latest.TagName, TitleInfo = latest.Name, TitleStyle = ResourceHelper.GetResource<Style>(ResourceToken.LabelViolet) };

                var unresolvedBody = latest.Body;
                var body = ResolveBody(unresolvedBody);

                foreach (var line in body)
                {
                    if (!line.Contains('#'))
                    {
                        string[] myStrings = { "more", "extra", "improved" };

                        if (myStrings.Any(line.ToLowerInvariant().Contains))
                        {
                            item.Members.Add(new ContentMember() { ContentTitle = "Addon", ContentInfo = line, ContentStyle = ResourceHelper.GetResource<Style>(ResourceToken.LabelInfo) });

                        }
                        else if (line.ToLowerInvariant().Contains("new"))
                        {
                            item.Members.Add(new ContentMember() { ContentTitle = "New", ContentInfo = line, ContentStyle = ResourceHelper.GetResource<Style>(ResourceToken.LabelSuccess) });

                        }
                        else if (line.ToLowerInvariant().Contains("breaking change"))
                        {
                            item.Members.Add(new ContentMember() { ContentTitle = "Breaking", ContentInfo = line, ContentStyle = ResourceHelper.GetResource<Style>(ResourceToken.LabelDanger) });

                        }
                        else if (line.ToLowerInvariant().Contains("overhaul"))
                        {
                            item.Members.Add(new ContentMember() { ContentTitle = "Overhaul", ContentInfo = line, ContentStyle = ResourceHelper.GetResource<Style>(ResourceToken.LabelWarning) });

                        }
                        else
                        {
                            item.Members.Add(new ContentMember() { ContentTitle = "Change", ContentInfo = line, ContentStyle = ResourceHelper.GetResource<Style>(ResourceToken.LabelPrimary) });

                        }

                    }

                }
                data.Add(item);
                gitTime.SetCurrentValue(ItemsControl.ItemsSourceProperty, data);
            }
            catch { }
        }

        private string[] ResolveBody(string unresolvedbody)
        {
            var step1 = Regex.Replace(unresolvedbody, @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline);
            var result = Regex.Split(step1, "\r\n|\r|\n");

            return result;
        }

        private void SideMenu_WelcomeItem_Selected(object sender, RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                PageViewGrid.Children.Clear();

                TopicViewer.TopicViewer.Children.Clear();
                TopicViewer.TopicViewer.Children.Add(WelcomePV);
            }

        }




        private void SideMenu_FirstUseItem_Selected(object sender, RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                PageViewGrid.Children.Clear();

                TopicViewer.TopicViewer.Children.Clear();
                TopicViewer.TopicViewer.Children.Add(FirstSWV);
            }
        }

        private void SideMenu_OpenRecentProjectItem_Selected(object sender, RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                PageViewGrid.Children.Clear();
                PageViewGrid.Children.Add(RecentPV);
            }
        }

        private void SideMenu_NewProjectItem_Selected(object sender, RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                PageViewGrid.Children.Clear();

                TopicViewer.TopicViewer.Children.Clear();
                TopicViewer.TopicViewer.Children.Add(ProjectWV);
            }
        }

        private void SideMenu_WikiItem_Selected(object sender, RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                PageViewGrid.Children.Clear();
                PageViewGrid.Children.Add(WikitPV);
            }
        }
   
        private void SideMenu_GitHubItem_Selected(object sender, RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                PageViewGrid.Children.Clear();
                PageViewGrid.Children.Add(GithubPV);
            }
        }

        private void SideMenu_AboutItem_Selected(object sender, RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                PageViewGrid.Children.Clear();
                PageViewGrid.Children.Add(AboutPV);
            }
        }

        private void SideMenu_SettingsItem_Selected(object sender, RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                PageViewGrid.Children.Clear();
                PageViewGrid.Children.Add(SettingsPV);
            }
        }
        
        private void SideMenu_WebsiteItem_Selected(object sender, RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                PageViewGrid.Children.Clear();
                PageViewGrid.Children.Add(WebsitePV);
            }
        }

        private void Tag_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                PageViewGrid.Children.Clear();
                PageViewGrid.Children.Add(UserPV);
            }

   






        }

        private void SideMenu_IntegratedItem_Selected(object sender, RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                PageViewGrid.Children.Clear();
                PageViewGrid.Children.Add(IntegratedTPV);
            }

        }

        private void Grid_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        
        }

        private void Grid_MouseLeftButtonDown_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
          
                var serviceLocator = ServiceLocator.Default;

                var shellService = serviceLocator.ResolveType<IShellService>();

                ShellWindow sh = (ShellWindow)shellService.Shell;
      
                sh.DragMove();
            
            // Begin dragging the window
        }
    }
}
