using Catel.IoC;
using Orchestra.Services;
using WolvenKit.Common.Services;

namespace WolvenKit.Functionality.WKitGlobal.Helpers
{
    public static class NotificationHelper
    {
        #region Properties

        /// <summary>
        ///
        /// </summary>
        public static INotificationService Growl => ServiceLocator.Default.ResolveType<INotificationService>();

        public static bool IsShowNotificationsEnabled { get; set; }

        #endregion Properties

        #region Methods

        public static void InitializeNotificationHelper() => Growl.NotificationCategory = ENotificationCategory.Desktop;

        #endregion Methods
    }
}
