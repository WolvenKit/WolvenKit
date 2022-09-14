using DynamicData;
using System;
using WolvenKit.Common.Services;
using WolvenKit.Common;

namespace WolvenKit.Core.Interfaces;

public interface ILoggerService
{
    public void Log(string msg, Logtype type = Logtype.Normal);

    public void Info(string s);

    public void Warning(string s);

    public void Error(string msg);

    public void Important(string msg);

    public void Success(string msg);



    public IObservable<IChangeSet<LogEntry>> Connect();


    public void Error(Exception exception);
}
