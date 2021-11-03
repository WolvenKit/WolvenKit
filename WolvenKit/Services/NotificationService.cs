using System;
using System.Windows;
using System.Windows.Threading;
using HandyControl.Controls;
using WolvenKit.Common.Services;

namespace WolvenKit.Services
{
    public class NotificationService : INotificationService
    {
        #region ctor

        public NotificationService()
        {
            IsShowNotificationsEnabled = true;
            NotificationCategory = ENotificationCategory.App;
        }

        #endregion

        #region properties

        public bool IsShowNotificationsEnabled { get; set; }
        public ENotificationCategory NotificationCategory { get; set; }

        #endregion

        #region methods

        public void Info(string message)
        {
            switch (NotificationCategory)
            {
                case ENotificationCategory.App:
                    ShowNotificationInApp(message, ENotificationType.Info);
                    break;
                case ENotificationCategory.Desktop:
                    ShowNotificationInDesktop(message, ENotificationType.Info);
                    break;
            }
        }

        public void Success(string message)
        {
            switch (NotificationCategory)
            {
                case ENotificationCategory.App:
                    ShowNotificationInApp(message, ENotificationType.Success);
                    break;
                case ENotificationCategory.Desktop:
                    ShowNotificationInDesktop(message, ENotificationType.Success);
                    break;
            }
        }

        public void Warning(string message)
        {
            switch (NotificationCategory)
            {
                case ENotificationCategory.App:
                    ShowNotificationInApp(message, ENotificationType.Warning);
                    break;
                case ENotificationCategory.Desktop:
                    ShowNotificationInDesktop(message, ENotificationType.Warning);
                    break;
            }
        }

        public void Error(string message)
        {
            switch (NotificationCategory)
            {
                case ENotificationCategory.App:
                    ShowNotificationInApp(message, ENotificationType.Error);
                    break;
                case ENotificationCategory.Desktop:
                    ShowNotificationInDesktop(message, ENotificationType.Error);
                    break;
            }
        }

        public void Fatal(string message)
        {
            switch (NotificationCategory)
            {
                case ENotificationCategory.App:
                    ShowNotificationInApp(message, ENotificationType.Fatal);
                    break;
                case ENotificationCategory.Desktop:
                    ShowNotificationInDesktop(message, ENotificationType.Fatal);
                    break;
            }
        }

        public void ShowNotification(string message, ENotificationType type, ENotificationCategory category)
        {
            switch (category)
            {
                case ENotificationCategory.App:
                    ShowNotificationInApp(message, type);
                    break;
                case ENotificationCategory.Desktop:
                    ShowNotificationInDesktop(message, type);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(category), category, null);
            }
        }

        public void Ask(string message, Func<bool, bool> isConfirmedFunc)
        {
            switch (NotificationCategory)
            {
                case ENotificationCategory.App:
                    AskInApp(message, isConfirmedFunc);
                    break;
                case ENotificationCategory.Desktop:
                    AskInDesktop(message, isConfirmedFunc);
                    break;
            }

        }

        public void AskInApp(string message, Func<bool, bool> func) => Growl.Ask(message, func);

        public void AskInDesktop(string message, Func<bool, bool> func) => Growl.AskGlobal(message, func);

        public void ShowAppNotification(string message, ENotificationType type) => ShowNotificationInApp(message, type);

        public void ShowDesktopNotification(string message, ENotificationType type) => ShowNotificationInDesktop(message, type);

        private static void ShowNotificationInDesktop(string message, ENotificationType type)
        {
            Action action = type switch
            {
                ENotificationType.Success => () => Growl.SuccessGlobal(message),
                ENotificationType.Info => () => Growl.InfoGlobal(message),
                ENotificationType.Warning => () => Growl.WarningGlobal(message),
                ENotificationType.Error => () => Growl.ErrorGlobal(message),
                ENotificationType.Fatal => () => Growl.FatalGlobal(message),
                _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
            };
            Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Background, action);
        }

        private static void ShowNotificationInApp(string message, ENotificationType type)
        {
            Action action = type switch
            {
                ENotificationType.Success => () => Growl.Success(message),
                ENotificationType.Info => () => Growl.Info(message),
                ENotificationType.Warning => () => Growl.Warning(message),
                ENotificationType.Error => () => Growl.Error(message),
                ENotificationType.Fatal => () => Growl.Fatal(message),
                _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
            };
            Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Background, action);
        }

        #endregion
    }
}
