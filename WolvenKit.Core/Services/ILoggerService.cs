using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common;

namespace WolvenKit.Common.Services
{
    public interface ILoggerService
    {
        void LogString(string msg, Logtype type);
        void LogProgress(float f);
        void LogProgress(float f, string msg);

        public void Log(string msg, Logtype type = Logtype.Normal);

        public void Info(string s);

        public void Warning(string s);

        public void Error(string msg);

        public void Important(string msg);

        public void Success(string msg);








    }
}
