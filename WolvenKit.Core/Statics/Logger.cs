using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common;
using WolvenKit.Common.Services;

namespace WolvenKit.Core
{
    public static class Logger
    {
        private static ILoggerService _logger => WolvenServiceLocator.Default.ResolveType<ILoggerService>();




        public static void Success(string msg) => _logger?.LogString(msg, Logtype.Success);

        public static void Error(string msg) => _logger?.LogString(msg, Logtype.Error);
    }
}
