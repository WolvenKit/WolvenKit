using System;
using System.Threading.Tasks;
using AdonisUI.Controls;
using ReactiveUI;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Interaction;
using WolvenKit.ViewModels.HomePage.Pages;
using WolvenKit.ViewModels.Shared;

namespace WolvenKit.Views.HomePage.Pages
{
    public partial class WelcomePageView : ReactiveUserControl<WelcomePageViewModel>
    {
        public WelcomePageView()
        {
            InitializeComponent();
            InitWebView2();

            this.WhenActivated(disposables =>
            {
                Interactions.Confirm.RegisterHandler(
                    interaction =>
                    {
                        var action = this.DisplayConfirmDialog(interaction.Input);
                        interaction.SetOutput(action);
                    });

                this.BindCommand(
                    this.ViewModel,
                    vm => vm.OpenLinkCommand,
                    v => v.DiscordLinkButton,
                    vm => vm.DiscordLink);
                this.BindCommand(
                    this.ViewModel,
                    vm => vm.OpenLinkCommand,
                    v => v.TwitterLinkButton,
                    vm => vm.TwitterLink);
                this.BindCommand(
                    this.ViewModel,
                    vm => vm.OpenLinkCommand,
                    v => v.OpenCollectiveLinkButton,
                    vm => vm.OpenCollectiveLink);
                this.BindCommand(
                    this.ViewModel,
                    vm => vm.OpenLinkCommand,
                    v => v.PatreonLinkButton,
                    vm => vm.PatreonLink);


            });

        }

        private bool DisplayConfirmDialog(string input)
        {
            var result = MessageBox.Show(
                "The file doesn't seem to exist. Would you like to locate it? ",
                "Project not found",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);

            return result == MessageBoxResult.Yes;
        }

        private async void InitWebView2()
        {
            if (!StaticReferences.IsWebView2Enabled)
            {
                return;
            }

            try
            {
                await cal.EnsureCoreWebView2Async(Helpers.objCoreWebView2Environment);

                cal.SetCurrentValue(Microsoft.Web.WebView2.Wpf.WebView2.SourceProperty, (System.Uri)new Uri("https://www.youtube.com/embed/WfEi3QwhTIs"));
            }
            catch (Exception)
            {
                // TODO: handle this
            }
        }
    }
}
