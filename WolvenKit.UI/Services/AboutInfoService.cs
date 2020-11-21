namespace WolvenKit.UI.Services
{
    using System;
    using Orchestra.Models;
    using Orchestra.Services;

    internal class AboutInfoService : IAboutInfoService
    {
        public AboutInfo GetAboutInfo()
        {
            var aboutInfo = new AboutInfo(new Uri("pack://application:,,,/Resources/Images/CompanyLogo.png", UriKind.RelativeOrAbsolute),
                uriInfo: new UriInfo("https://www.catelproject.com", "Product website"));

            return aboutInfo;
        }
    }
}
