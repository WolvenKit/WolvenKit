
using HandyControl.Controls;
using HandyControl.Data;
using HandyControl.Tools;
using Octokit;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WolvenKit.Views.HomePage.Pages
{
    public partial class AboutPageView
    {
        public AboutPageView()
        {
            InitializeComponent(); 
            InitializeGitHub();

        }

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                DiscordRPCHelper.WhatAmIDoing("About Page");
            }
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
    }
}
