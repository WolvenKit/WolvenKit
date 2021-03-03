using Catel.IoC;
using Orchestra.Services;

namespace WolvenKit.Functionality.WKitGlobal.Helpers
{
    public static class NotificationHelper
    {
        /// <summary>
        ///
        /// </summary>
        public static IGrowlNotificationService Growl => ServiceLocator.Default.ResolveType<IGrowlNotificationService>();

        public static void InitializeNotificationHelper()
        {
            Growl.NotificationCategory = ENotificationCategory.App;
        }
    }
}
