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

        void Error(string message);
        void Fatal(string message);
        void Info(string message);
        void Success(string message);
        void Warning(string message);

        void Ask(string message, Func<bool, bool> isConfirmedFunc);

        void ShowAppNotification(string message, ENotificationType type);
        void ShowDesktopNotification(string message, ENotificationType type);
        void ShowNotification(string message, ENotificationType type, ENotificationCategory category);
        
    }
}
