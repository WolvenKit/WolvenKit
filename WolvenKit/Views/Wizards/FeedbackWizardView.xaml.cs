using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using Discord;
using Discord.WebSocket;
using ReactiveUI;
using Splat;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Wizards;

namespace WolvenKit.Views.Wizards
{
    public partial class FeedbackWizardView : ReactiveUserControl<FeedbackWizardViewModel>
    {
        private static SocketTextChannel ms_hashChannel { get; set; }

        #region Constructors

        private DiscordSocketClient Static_Client;

        public FeedbackWizardView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<FeedbackWizardViewModel>();
            DataContext = ViewModel;

            TestConnect();
        }

        #endregion Constructors

        private string _authortitle;

        private string _reviewtitle;
        private string _reviewtext;

        private async void WizardControl_Finish(object sender, System.Windows.RoutedEventArgs e)
        {
            if (reviewtitle.Text == "" || authortitle.Text == "" || ratingrater.Value.ToString() == "0")
            {
                MessageBox.Show("Not all boxes were filled in and or no severity was selected.\nClosing Feedback dialog.", "Error sending feedback");
                return;
            }
            _reviewtext = new TextRange(reviewtext.Document.ContentStart, reviewtext.Document.ContentEnd).Text;
            _reviewtitle = reviewtitle.Text;
            _authortitle = authortitle.Text;
            await SendMessage();

            await Static_Client.StopAsync();
        }

        public async Task SendMessage()

        {
            var _settingsManager = Locator.Current.GetService<ISettingsManager>();
            var teststring = "Reviewer : ``" + _authortitle + "``\n"
                + "||-||\n"
                + "||-||:arrow_down: **Review** :arrow_down: \n" +
                "```" + _reviewtext + "```";

            var qa = teststring.Length > 2047 ? teststring.Substring(0, 2048) : teststring;
            var embed = new EmbedBuilder
            {
                Color = Color.Green,
                // Embed property can be set within object initializer
                Title = "<a:wkit:808759605559164989> **| Wolvenkit Review : **" + _reviewtitle + " |",
                Description = qa,
                Footer = new EmbedFooterBuilder
                {
                    Text = "This review was sent from Wolvenkit Version : " + _settingsManager.GetVersionNumber()
                }
            };

            await ms_hashChannel.SendMessageAsync(embed: embed.Build());
        }

        public async void TestConnect() => await Connect();

        public async Task Connect()
        {
            Static_Client = new DiscordSocketClient();
            Static_Client.Ready += () => SetupChannels();
            await Static_Client.LoginAsync(TokenType.Bot, Reverse("EN9kE0T0boXxIuL8BDcKtP2fdxJ.AnGLIY.3ADMzQTMwUzN1YDO5MTM1MDO"));
            await Static_Client.StartAsync();
        }

        public static string Reverse(string s)
        {
            var charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private Task SetupChannels()
        {
            ms_hashChannel = Static_Client.GetGuild(717692382849663036).GetTextChannel(860207250701942824);
            return Task.CompletedTask;
        }
    }
}
