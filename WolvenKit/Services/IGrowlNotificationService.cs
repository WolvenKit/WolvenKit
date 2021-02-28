using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Services
{
    public interface IGrowlNotificationService
    {
        public bool IsShowNotificationsEnabled { get; set; }
        public ENotificationCategory NotificationCategory { get; set; }

        public void ShowNotification(string message, ENotificationType type, ENotificationCategory category);
        public void ShowAppNotification(string message, ENotificationType type);
        public void ShowDesktopNotification(string message, ENotificationType type);

        public void Info(string message);
        public void Success(string message);
        public void Warning(string message);
        public void Error(string message);
        public void Fatal(string message);



    }

    public enum ENotificationType
    {
        Success,
        Info,
        Warning,
        Error,
        Fatal
    }

    public enum ENotificationCategory
    {
        App,
        Desktop
    }
}
