using System;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
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
                await cal.EnsureCoreWebView2Async(Helpers.objCoreWebView2Environment);

                cal.SetCurrentValue(Microsoft.Web.WebView2.Wpf.WebView2.SourceProperty, (System.Uri)new Uri("https://github.com/WolvenKit/Wolven-kit"));
            }
            catch (Exception)
            {
                // TODO: handle this
            }
        }

        #endregion Constructors
    }
}
