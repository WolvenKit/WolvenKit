using System;
using Microsoft.Web.WebView2.Core;
using WolvenKit.Functionality.Helpers;

namespace WolvenKit.Views.HomePage.Pages
{
    public partial class GithubPageView
    {
        #region Constructors

        public GithubPageView()
        {
            InitializeComponent();
            dome();
        }

        private async void dome()
        {
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
