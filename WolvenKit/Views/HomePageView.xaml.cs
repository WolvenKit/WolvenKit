
using HandyControl.Controls;
using HandyControl.Data;
using HandyControl.Tools;
using Octokit;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WolvenKit.Views
{
    public partial class HomePageView
    {
        public HomePageView()
        {
            InitializeComponent();


            InitiializeGitHub();
        }

        private async void InitiializeGitHub()
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
            var releases = await GhubClient.Repository.Release.GetAll("WolvenKit", "Wolven-Kit");
            var latest = releases[0];


            ObservableCollection<GithubTimeLine> data = new ObservableCollection<GithubTimeLine>();

            var item = new GithubTimeLine() { TitleLabel = latest.TagName, TitleInfo = latest.Name, TitleStyle = ResourceHelper.GetResource<Style>(ResourceToken.LabelViolet) };

            var unresolvedbody = latest.Body;
            var body = await ResolveBody(unresolvedbody);

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

        private async Task<string[]> ResolveBody(string unresolvedbody)
        {
            var Step1 = Regex.Replace(unresolvedbody, @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline);
            var result = Regex.Split(Step1, "\r\n|\r|\n");

            return result;
        }
    }
}
