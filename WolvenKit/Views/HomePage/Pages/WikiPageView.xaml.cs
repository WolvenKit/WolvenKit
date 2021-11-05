using System;
using Microsoft.Web.WebView2.Core;
using ReactiveUI;
using Splat;
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

            ViewModel = Locator.Current.GetService<WikiPageViewModel>();
            DataContext = ViewModel;

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

                cal.SetCurrentValue(Microsoft.Web.WebView2.Wpf.WebView2.SourceProperty, (System.Uri)new Uri("https://wiki.redmodding.org/wolvenkit/"));
            }
            catch (Exception)
            {
                
            }
        }
    }
}
