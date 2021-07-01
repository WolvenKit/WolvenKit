using System.Diagnostics;
using System.Threading.Tasks;
using Catel.IoC;
using Discord;
using Discord.WebSocket;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.ViewModels.Wizards;

namespace WolvenKit.Views.Wizards
{
    public partial class BugReportWizardView
    {
        #region Constructors

        public BugReportWizardView()
        {
            InitializeComponent();
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
            authortitle = authortitlebox.Text;
            messagetitle = messagetitlebox.Text;
            reprosteps = reprostepsbox.Text;
            expectedtext = expectedbehavbox.Text;
            actualtext = actbehavtitlebox.Text;
            aditionaltext = additioncontextbox.Text;
            severity = SevRater.Count.ToString();
            await SendMessage();

            await Static_Client.StopAsync();
        }

        private DiscordSocketClient Static_Client;
        private static SocketTextChannel ms_hashChannel { get; set; }

        private string randomstring = "ODM1MTM5ODY1NzUwMTQzMDA3.YILGnA.3O7eZiptM5vuxO1_GgTsukrknHk";

        public async Task SendMessage()
        {
            var _settingsManager = ServiceLocator.Default.ResolveType<ISettingsManager>();

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
                Title = "<a:wkit:808759605559164989> **Bug report : **" + messagetitle + "|:robot: By : ``" + authortitle + "``",
                Description = "```This bug report was sent from Wolvenkit Version : " + _settingsManager.GetVersionNumber() + "```\n"
                + "Use ``!gh -c`` to start making an issue for this bug report.\n"
                + "Or use this link to go to the Github issues page : [Issues](https://github.com/WolvenKit/WolvenKit/issues)\n"
                + " ",
                Fields = new System.Collections.Generic.List<EmbedFieldBuilder> { z, z2, z1, z3, z4 },
            };

            await ms_hashChannel.SendMessageAsync(embed: embed.Build());
        }

        public async void TestConnect()
        {
            await Connect();
        }

        public async Task Connect()
        {
            Static_Client = new DiscordSocketClient();
            Static_Client.Ready += () => SetupChannels();
            Static_Client.Log += Log;
            await Static_Client.LoginAsync(TokenType.Bot, randomstring);
            await Static_Client.StartAsync();
        }

        public static Task Log(LogMessage msg)
        {
            Trace.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }

        private Task SetupChannels()
        {
            ms_hashChannel = Static_Client.GetGuild(717692382849663036).GetTextChannel(860207140916166707);
            return Task.CompletedTask;
        }
    }
}
