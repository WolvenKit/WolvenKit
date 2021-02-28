using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.IoC;
using WolvenKit.Services;

namespace WolvenKit.WKitGlobal
{
    public static class NotificationHelper
    {
        /// <summary>
        /// 
        /// </summary>
        public static IGrowlNotificationService Growl => ServiceLocator.Default.ResolveType<IGrowlNotificationService>();


    }
}
