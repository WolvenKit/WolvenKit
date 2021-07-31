using System;
using Microsoft.Web.WebView2.Core;
using ReactiveUI;
using WolvenKit.Functionality.Helpers;
using WolvenKit.ViewModels.HomePage.Pages;

namespace WolvenKit.Views.HomePage.Pages
{
    public partial class WikiPageView : ReactiveUserControl<WikiPageViewModel>
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
            if (!StaticReferences.IsWebView2Enabled)
            {
                return;
            }

            try
            {
                await cal.EnsureCoreWebView2Async(Helpers.objCoreWebView2Environment);

                cal.SetCurrentValue(Microsoft.Web.WebView2.Wpf.WebView2.SourceProperty, (System.Uri)new Uri("https://wiki.cybermods.net/wolvenkit/"));
            }
            catch (Exception)
            {
                
            }
        }
    }
}
