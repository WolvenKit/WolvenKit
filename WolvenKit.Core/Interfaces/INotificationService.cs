using System;

namespace WolvenKit.Common.Services
{
    public enum ENotificationCategory
    {
        App,
        Desktop
    }

    public enum ENotificationType
    {
        Success,
        Info,
        Warning,
        Error,
        Fatal,
    }

    public interface INotificationService
    {
        bool IsShowNotificationsEnabled { get; set; }
        ENotificationCategory NotificationCategory { get; set; }

        void Error(string message, bool staysOpen = false);
        void Fatal(string message, bool staysOpen = false);
        void Info(string message, bool staysOpen = false);
        void Success(string message, bool staysOpen = false);
        void Warning(string message, bool staysOpen = false);

        void Ask(string message, Func<bool, bool> isConfirmedFunc);

        void ShowAppNotification(string message, ENotificationType type, bool staysOpen = false);
        void ShowDesktopNotification(string message, ENotificationType type, bool staysOpen = false);
        void ShowNotification(string message, ENotificationType type, ENotificationCategory category);
        void AskInApp(string message, Func<bool, bool> func);
        void AskInDesktop(string message, Func<bool, bool> func);
    }
}
