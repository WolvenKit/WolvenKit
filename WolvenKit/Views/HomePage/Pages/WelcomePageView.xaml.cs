using System;
using System.Reactive.Disposables;
using System.Threading.Tasks;
using ReactiveUI;
using Splat;
using WolvenKit.App.ViewModels.HomePage.Pages;
using WolvenKit.Functionality.Helpers;

namespace WolvenKit.Views.HomePage.Pages
{
    public partial class WelcomePageView : ReactiveUserControl<WelcomePageViewModel>
    {
        public WelcomePageView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<WelcomePageViewModel>();
            DataContext = ViewModel;

            InitWebView2();

            this.WhenActivated(disposables =>
            {
                this.BindCommand(
                    ViewModel,
                    vm => vm.OpenLinkCommand,
                    v => v.DiscordLinkButton,
                    vm => vm.DiscordLink);
                this.BindCommand(
                    ViewModel,
                    vm => vm.OpenLinkCommand,
                    v => v.YoutubeLinkButton,
                    vm => vm.YoutubeLink);
                //Twitter Link Not Used
                //this.BindCommand(
                //this.ViewModel,
                //vm => vm.OpenLinkCommand,
                //v => v.TwitterLinkButton,
                //vm => vm.TwitterLink);
                this.BindCommand(
                    ViewModel,
                    vm => vm.OpenLinkCommand,
                    v => v.OpenCollectiveLinkButton,
                    vm => vm.OpenCollectiveLink);
                this.BindCommand(
                    ViewModel,
                    vm => vm.OpenLinkCommand,
                    v => v.PatreonLinkButton,
                    vm => vm.PatreonLink);


                this.BindCommand(ViewModel,
                        viewModel => viewModel.NewProjectCommand,
                        view => view.NewProjectButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.OpenProjectCommand,
                        view => view.OpenProjectButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.CloseHomePage,
                        view => view.ContinueWithoutProjectButton)
                    .DisposeWith(disposables);



            });

        }

        private async void InitWebView2()
        {
            if (!StaticReferences.IsWebView2Enabled)
            {
                return;
            }

            try
            {
                await Task.CompletedTask;
                //await FeaturedVideo.EnsureCoreWebView2Async(Helpers.objCoreWebView2Environment);

                //FeaturedVideo.SetCurrentValue(Microsoft.Web.WebView2.Wpf.WebView2.SourceProperty, (System.Uri)new Uri("https://www.youtube.com/embed/WfEi3QwhTIs"));
            }
            catch (Exception)
            {
                // TODO: handle this
            }
        }
    }
}
