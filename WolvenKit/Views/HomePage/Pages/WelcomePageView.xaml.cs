using System;
using WolvenKit.Functionality.Helpers;

namespace WolvenKit.Views.HomePage.Pages
{
    public partial class WelcomePageView
    {
        public WelcomePageView()
        {
            InitializeComponent();
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

                cal.SetCurrentValue(Microsoft.Web.WebView2.Wpf.WebView2.SourceProperty, (System.Uri)new Uri("https://www.youtube.com/embed/WfEi3QwhTIs"));
            }
            catch (Exception)
            {
                // TODO: handle this
            }
        }
    }
}
