using System;
using ReactiveUI;
using Splat;
using WolvenKit.Functionality.Helpers;
using WolvenKit.ViewModels.HomePage.Pages;

namespace WolvenKit.Views.HomePage.Pages
{
    public partial class GithubPageView : ReactiveUserControl<GithubPageViewModel>
    {
        #region Constructors

        public GithubPageView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<GithubPageViewModel>();
            DataContext = ViewModel;

            dome();
        }

        private async void dome()
        {
            if (!StaticReferences.IsWebView2Enabled)
            {
                return;
            }

            try
            {
                await cal.EnsureCoreWebView2Async(WebView2Helper.objCoreWebView2Environment);

                cal.SetCurrentValue(Microsoft.Web.WebView2.Wpf.WebView2.SourceProperty, new Uri("https://github.com/WolvenKit/WolvenKit"));
            }
            catch (Exception)
            {
                // TODO: handle this
            }
        }

        #endregion Constructors
    }
}
