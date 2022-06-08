using System;
using System.Threading.Tasks;
using System.Windows.Documents;
using Discord;
using Discord.WebSocket;
using HandyControl.Controls;
using ReactiveUI;
using Splat;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Wizards;

namespace WolvenKit.Views.Wizards
{
    public partial class BugReportWizardView : ReactiveUserControl<BugReportWizardViewModel>
    {
        #region Constructors

        public BugReportWizardView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<BugReportWizardViewModel>();
            DataContext = ViewModel;

            TestConnect();
        }

        #endregion Constructors

        private string authortitle;

        private string messagetitle;
        private string reprosteps;
        private string expectedtext;
        private string actualtext;
        private string aditionaltext;
        private string severity;

        private async void WizardControl_Finish(object sender, System.Windows.RoutedEventArgs e)
        {
            if (
             authortitlebox.Text == "" ||
             messagetitlebox.Text == "" ||
             new TextRange(reprostepsbox.Document.ContentStart, reprostepsbox.Document.ContentEnd).Text == "" ||
             new TextRange(expectedbehavbox.Document.ContentStart, expectedbehavbox.Document.ContentEnd).Text == "" ||
             new TextRange(actbehavtitlebox.Document.ContentStart, actbehavtitlebox.Document.ContentEnd).Text == "" ||
             new TextRange(reprostepsbox.Document.ContentStart, reprostepsbox.Document.ContentEnd).Text == "" ||
             SevRater.Value.ToString() == "0")
            {
                MessageBox.Show("Not all boxes were filled in and or no severity was selected.\nClosing bug reporter.", "Error sending report");
                return;
            }
            authortitle = authortitlebox.Text;
            messagetitle = messagetitlebox.Text;
            reprosteps = new TextRange(reprostepsbox.Document.ContentStart, reprostepsbox.Document.ContentEnd).Text;
            expectedtext = new TextRange(expectedbehavbox.Document.ContentStart, expectedbehavbox.Document.ContentEnd).Text;
            actualtext = new TextRange(actbehavtitlebox.Document.ContentStart, actbehavtitlebox.Document.ContentEnd).Text;
            aditionaltext = new TextRange(additioncontextbox.Document.ContentStart, additioncontextbox.Document.ContentEnd).Text;
            severity = SevRater.Value.ToString();
            await SendMessage();

            await Static_Client.StopAsync();
        }

        private DiscordSocketClient Static_Client;
        private static SocketTextChannel ms_hashChannel { get; set; }

        public async Task SendMessage()

        {
            var _settingsManager = Locator.Current.GetService<ISettingsManager>();

            var z = new EmbedFieldBuilder
            {
                IsInline = false,
                Name = "**Expect Behavior**",
                Value = "```" + expectedtext + "```"
            };
            var z2 = new EmbedFieldBuilder
            {
                IsInline = false,
                Name = "**Actual Behavior**",
                Value = "```" + actualtext + "```"
            };
            var z1 = new EmbedFieldBuilder
            {
                IsInline = false,
                Name = "**Steps to Reproduce**",
                Value = "```" + reprosteps + "```"
            };
            var z3 = new EmbedFieldBuilder
            {
                IsInline = false,
                Name = "**Additional Information**",
                Value = "```" + aditionaltext + "```"
            };
            var z4 = new EmbedFieldBuilder
            {
                IsInline = false,
                Name = "**Severity Rating (5 is Worst)**",
                Value = "```" + severity + "```"
            };
            var embed = new EmbedBuilder
            {
                Color = Color.Green,
                // Embed property can be set within object initializer
                Title = "<a:wkit:808759605559164989> **| Bug report : **" + messagetitle + " |",
                Description = "Reporter : ``" + authortitle + "``\n"
                + "||-||\n"
                + "||-|| Use ``!gh -c`` to start making an issue for this bug report.\n"
                + "||-|| Or use this link to go to the Github issues page : [Issues](https://github.com/WolvenKit/WolvenKit/issues)\n"
                + "||-||",
                Fields = new System.Collections.Generic.List<EmbedFieldBuilder> { z, z2, z1, z3, z4 },
                Footer = new EmbedFooterBuilder
                {
                    Text = "This bug report was sent from Wolvenkit Version : " + _settingsManager.GetVersionNumber()
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
            ms_hashChannel = Static_Client.GetGuild(717692382849663036).GetTextChannel(860207140916166707);
            return Task.CompletedTask;
        }
    }
}
