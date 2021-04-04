using System;
using System.Windows;
using Microsoft.Web.WebView2.Core;

namespace WolvenKit.Views.HomePage.Pages
{
    public partial class WikiPageView
    {
        #region Constructors

        public WikiPageView()
        {
            InitializeComponent();
            dome();
        }

        private async void dome()
        {
            CoreWebView2Environment objCoreWebView2Environment = await CoreWebView2Environment.CreateAsync(null, @"C:\WebViewData");
            await cal.EnsureCoreWebView2Async(objCoreWebView2Environment);
            cal.SetCurrentValue(Microsoft.Web.WebView2.Wpf.WebView2.SourceProperty, (System.Uri)new Uri("https://wiki.cybermods.net/wolvenkit/"));
        }

        #endregion Constructors

        #region Methods

        private void UserControl_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
        }

        #endregion Methods
    }
}
