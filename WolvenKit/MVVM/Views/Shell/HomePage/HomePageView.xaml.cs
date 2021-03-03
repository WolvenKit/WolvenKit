using Fluent;
using HandyControl.Controls;
using HandyControl.Data;
using HandyControl.Tools;
using Octokit;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.MVVM.Views.Shell.HomePage.Pages;
using WolvenKit.MVVM.Views.Components.Wizards;
using WolvenKit.MVVM.Views.Others;
using WolvenKit.MVVM.ViewModels.Others;

namespace WolvenKit.MVVM.Views.Shell.HomePage
{
    public partial class HomePageView
    {
        public static HomePageView GlobalHomePage;


        public WelcomePageView WelcomePV;
        public FirstSetupWizardView FirstSWV;
        public RecentProjectView RecentPV;
        public ProjectWizardView ProjectWV;
        public WikiPageView WikitPV;
        public AboutPageView AboutPV;
        public SettingsPageView SettingsPV;
        public WebsitePageView WebsitePV;
        public UserPageView UserPV;
        public IntegratedToolsPageView IntegratedTPV;
        public GithubPageView GithubPV;
        public DebugPageView DebugPV;


        public HomePageView()
        {
            InitializeComponent();
            GlobalHomePage = this;
            InitializeGitHub();
            InitializePages();

        }

        private void setupProjectWV()
        {
            /*ProjectWV.Loaded += (_s, _e) =>
                (ProjectWV.ViewModel as ProjectWizardViewModel).ClosingRequest
                    += (s, e) =>
                    {
                        SideMenu_WelcomeItem_Selected(s, new RoutedEventArgs());
                        ProjectWV = new ProjectWizardView();
                        setupProjectWV();
                    };*/
        }

        private void InitializePages()
        {
            WelcomePV = new WelcomePageView();
            FirstSWV = new FirstSetupWizardView();
            RecentPV = new RecentProjectView();
            ProjectWV = new ProjectWizardView();
            setupProjectWV();
            WikitPV = new WikiPageView();
            AboutPV = new AboutPageView();
            SettingsPV = new SettingsPageView();
            WebsitePV = new WebsitePageView();
            UserPV = new UserPageView();
            GithubPV = new GithubPageView();
            IntegratedTPV = new IntegratedToolsPageView();
            DebugPV = new DebugPageView();

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


                //  WatchShield.SetCurrentValue(Shield.StatusProperty, g_watchers.ToString());
                // ForkShield.SetCurrentValue(Shield.StatusProperty, g_forks.ToString());
                //   StarShield.SetCurrentValue(Shield.StatusProperty, g_stars.ToString());





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
                //  gitTime.SetCurrentValue(ItemsControl.ItemsSourceProperty, data);
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

                PageViewGrid.Children.Clear();
                PageViewGrid.Children.Add(WelcomePV);
            }

        }




        private void SideMenu_FirstUseItem_Selected(object sender, RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                FirstSetupWizardView rpv = new FirstSetupWizardView();
                UserControlHostWindowViewModel zxc = new UserControlHostWindowViewModel(rpv);
                UserControlHostWindowView uchwv = new UserControlHostWindowView(zxc);
                uchwv.Show();



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
                ProjectWizardView rpv = new ProjectWizardView();
                UserControlHostWindowViewModel zxc = new UserControlHostWindowViewModel(rpv);
                UserControlHostWindowView uchwv = new UserControlHostWindowView(zxc);
                uchwv.Show();
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

        private void SideMenu_UserItem_Selected(object sender, RoutedEventArgs e)
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
            base.OnMouseLeftButtonDown(e);




            StaticReferences.GlobalShell.DragMove();
        }

        private void Grid_MouseLeftButtonDown_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);




            StaticReferences.GlobalShell.DragMove();

            // Begin dragging the window
        }

        private void UserControl_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible)
            {
                DiscordHelper.SetDiscordRPCStatus("Home");

                if (IsVisible && IsLoaded)
                {
                    PageViewGrid.Children.Clear();
                    PageViewGrid.Children.Add(WelcomePV);

                }

            }

        }



        private void Grid_MouseLeftButtonDown_2(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (this.IsMouseOver)
                {
                    if (StaticReferences.GlobalShell.WindowState == WindowState.Maximized)
                    {
                        StaticReferences.GlobalShell.SetCurrentValue(System.Windows.Window.WindowStateProperty, WindowState.Normal);

                    }
                    else
                    {
                        StaticReferences.GlobalShell.SetCurrentValue(System.Windows.Window.WindowStateProperty, WindowState.Maximized);

                    }
                }
            }
            else
            {
                base.OnMouseLeftButtonDown(e);




                StaticReferences.GlobalShell.DragMove();
            }
        }

        private void SideMenu_DebugItem_Selected(object sender, RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                PageViewGrid.Children.Clear();
                PageViewGrid.Children.Add(DebugPV);
            }
        }

        private void Image_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            StaticReferences.RibbonViewInstance.startScreen.SetCurrentValue(StartScreen.ShownProperty, false);
            StaticReferences.RibbonViewInstance.startScreen.SetCurrentValue(Fluent.Backstage.IsOpenProperty, false);
        }
    }
}
