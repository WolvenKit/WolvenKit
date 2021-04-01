using System;
using System.Windows.Media.Imaging;
using Orchestra.Models;
using Orchestra.Services;

namespace WolvenKit.Functionality.Services
{
    internal class AboutInfoService : IAboutInfoService
    {
        #region Methods

        public AboutInfo GetAboutInfo()
        {
            var bitmap = new BitmapImage(new Uri("pack://application:,,,/Resources/Media/Images/Application/3.png", UriKind.RelativeOrAbsolute));
            var aboutInfo = new AboutInfo(
                                description: "An all in one modkit for modern CDPR games.",
                                appIcon: bitmap,
                                uriInfo: new UriInfo("https://github.com/WolvenKit/Wolven-kit", "Github Page")
                                );
            return aboutInfo;
        }

        #endregion Methods
    }
}
