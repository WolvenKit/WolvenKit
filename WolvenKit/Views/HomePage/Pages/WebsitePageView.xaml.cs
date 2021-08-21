using System;
using Microsoft.Web.WebView2.Core;
using ReactiveUI;
using Splat;
using WolvenKit.Functionality.Helpers;
using WolvenKit.ViewModels.HomePage.Pages;

namespace WolvenKit.Views.HomePage.Pages
{
    public partial class WebsitePageView : ReactiveUserControl<WebsitePageViewModel>
    {
        #region Constructors

        public WebsitePageView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<WebsitePageViewModel>();
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
                cal.SetCurrentValue(Microsoft.Web.WebView2.Wpf.WebView2.SourceProperty, (System.Uri)new Uri("https://redmodding.org/"));
            }
            catch (Exception)
            {
                // TODO: handle this
            }
        }
        #endregion Constructors
    }
}
