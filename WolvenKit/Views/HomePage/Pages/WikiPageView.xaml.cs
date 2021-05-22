using System;
using Catel.Logging;
using Microsoft.Web.WebView2.Core;
using WolvenKit.Functionality.Helpers;

namespace WolvenKit.Views.HomePage.Pages
{
    public partial class WikiPageView
    {
        // Constructor
        public WikiPageView()
        {
            InitializeComponent();
            InitializeWebviev();
        }

        // initialize webviev for Wiki page.
        private async void InitializeWebviev()
        {
            try
            {
                CoreWebView2Environment objCoreWebView2Environment = await CoreWebView2Environment.CreateAsync(null, @"C:\WebViewData");
                await cal.EnsureCoreWebView2Async(objCoreWebView2Environment);
                cal.SetCurrentValue(Microsoft.Web.WebView2.Wpf.WebView2.SourceProperty, (System.Uri)new Uri("https://wiki.cybermods.net/wolvenkit/"));
            }
            catch (Exception e)
            {
                StaticReferences.Logger.Error(e);
            }
        }
    }
}
