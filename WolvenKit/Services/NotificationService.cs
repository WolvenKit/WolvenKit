using System;
using System.Windows;
using System.Windows.Threading;
using HandyControl.Controls;
using HandyControl.Data;
using WolvenKit.App.Helpers;
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

        public void Info(string message, bool staysOpen = false)
        {
            switch (NotificationCategory)
            {
                case ENotificationCategory.App:
                    ShowNotificationInApp(message, ENotificationType.Info, staysOpen);
                    break;
                case ENotificationCategory.Desktop:
                    ShowNotificationInDesktop(message, ENotificationType.Info, staysOpen);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(NotificationCategory), NotificationCategory, null);
            }
        }

        public void Success(string message, bool staysOpen = false)
        {
            switch (NotificationCategory)
            {
                case ENotificationCategory.App:
                    ShowNotificationInApp(message, ENotificationType.Success, staysOpen);
                    break;
                case ENotificationCategory.Desktop:
                    ShowNotificationInDesktop(message, ENotificationType.Success, staysOpen);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(NotificationCategory), NotificationCategory, null);
            }
        }

        public void Warning(string message, bool staysOpen = false)
        {
            switch (NotificationCategory)
            {
                case ENotificationCategory.App:
                    ShowNotificationInApp(message, ENotificationType.Warning, staysOpen);
                    break;
                case ENotificationCategory.Desktop:
                    ShowNotificationInDesktop(message, ENotificationType.Warning, staysOpen);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(NotificationCategory), NotificationCategory, null);
            }
        }

        public void Error(string message, bool staysOpen = false)
        {
            switch (NotificationCategory)
            {
                case ENotificationCategory.App:
                    ShowNotificationInApp(message, ENotificationType.Error, staysOpen);
                    break;
                case ENotificationCategory.Desktop:
                    ShowNotificationInDesktop(message, ENotificationType.Error, staysOpen);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(NotificationCategory), NotificationCategory, null);
            }
        }

        public void Fatal(string message, bool staysOpen = false)
        {
            switch (NotificationCategory)
            {
                case ENotificationCategory.App:
                    ShowNotificationInApp(message, ENotificationType.Fatal, staysOpen);
                    break;
                case ENotificationCategory.Desktop:
                    ShowNotificationInDesktop(message, ENotificationType.Fatal, staysOpen);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(NotificationCategory), NotificationCategory, null);
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
                default:
                    throw new ArgumentOutOfRangeException(nameof(NotificationCategory), NotificationCategory, null);
            }

        }

        public void AskInApp(string message, Func<bool, bool> func) => Growl.Ask(message, func);

        public void AskInDesktop(string message, Func<bool, bool> func) => Growl.AskGlobal(message, func);

        public void ShowAppNotification(string message, ENotificationType type, bool staysOpen = false) => ShowNotificationInApp(message, type, staysOpen);

        public void ShowDesktopNotification(string message, ENotificationType type, bool staysOpen = false) => ShowNotificationInDesktop(message, type, staysOpen);

        private static void ShowNotificationInDesktop(string message, ENotificationType type, bool staysOpen = false)
        {
            Action action = type switch
            {
                ENotificationType.Success => () =>
                    Growl.SuccessGlobal(new GrowlInfo
                    {
                        Message = message, Token = "", StaysOpen = staysOpen, WaitTime = 5
                    }),
                ENotificationType.Info => () =>
                    Growl.InfoGlobal(new GrowlInfo
                    {
                        Message = message, Token = "", StaysOpen = staysOpen, WaitTime = 5
                    }),
                ENotificationType.Warning => () =>
                    Growl.WarningGlobal(new GrowlInfo
                    {
                        Message = message, Token = "", StaysOpen = staysOpen, WaitTime = 5
                    }),
                ENotificationType.Error => () =>
                    Growl.ErrorGlobal(new GrowlInfo
                    {
                        Message = message, Token = "", StaysOpen = staysOpen, WaitTime = 5
                    }),
                ENotificationType.Fatal => () =>
                    Growl.FatalGlobal(new GrowlInfo
                    {
                        Message = message, Token = "", StaysOpen = staysOpen, WaitTime = 5
                    }),
                _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
            };
            DispatcherHelper.RunOnMainThread(action, DispatcherPriority.Background);
        }

        private static void ShowNotificationInApp(string message, ENotificationType type, bool staysOpen = false)
        {
            Action action = type switch
            {
                ENotificationType.Success => () =>
                    Growl.Success(new GrowlInfo
                    {
                        Message = message, Token = "", StaysOpen = staysOpen, WaitTime = 5
                    }),
                ENotificationType.Info => () =>
                    Growl.Info(new GrowlInfo { Message = message, Token = "", StaysOpen = staysOpen, WaitTime = 5 }),
                ENotificationType.Warning => () =>
                    Growl.Warning(new GrowlInfo
                    {
                        Message = message, Token = "", StaysOpen = staysOpen, WaitTime = 5
                    }),
                ENotificationType.Error => () =>
                    Growl.Error(new GrowlInfo { Message = message, Token = "", StaysOpen = staysOpen, WaitTime = 5 }),
                ENotificationType.Fatal => () =>
                    Growl.Fatal(new GrowlInfo { Message = message, Token = "", StaysOpen = staysOpen, WaitTime = 5 }),
                _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
            };
            DispatcherHelper.RunOnMainThread(action, DispatcherPriority.Background);
        }

        #endregion
    }
}
