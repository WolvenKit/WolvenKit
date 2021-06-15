using Catel.IoC;
using Orchestra.Services;

namespace WolvenKit.Functionality.WKitGlobal.Helpers
{
    public static class NotificationHelper
    {
        #region Properties

        /// <summary>
        ///
        /// </summary>
        public static IGrowlNotificationService Growl => ServiceLocator.Default.ResolveType<IGrowlNotificationService>();

        #endregion Properties

        #region Methods

        public static void InitializeNotificationHelper() => Growl.NotificationCategory = ENotificationCategory.Desktop;

        #endregion Methods
    }
}
