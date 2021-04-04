using System;
using Microsoft.Web.WebView2.Core;

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
            CoreWebView2Environment objCoreWebView2Environment = await CoreWebView2Environment.CreateAsync(null, @"C:\WebViewData", null);
            await cal.EnsureCoreWebView2Async(objCoreWebView2Environment);
            cal.SetCurrentValue(Microsoft.Web.WebView2.Wpf.WebView2.SourceProperty, (System.Uri)new Uri("https://github.com/WolvenKit/Wolven-kit"));

        }

        #endregion Constructors
    }
}
