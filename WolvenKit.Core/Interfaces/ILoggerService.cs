using System;
using DynamicData;
using Microsoft.Build.Framework;
using WolvenKit.Common;
using WolvenKit.Common.Services;

namespace WolvenKit.Core.Interfaces;

public interface ILoggerService
{
    public void Info(string s);

    public void Warning(string s);

    public void Error(string msg);

    public void Important(string msg);

    public void Success(string msg);



    public IObservable<IChangeSet<LogEntry>> Connect();


    public void Error(Exception exception);

    public LoggerVerbosity LoggerVerbosity { get; }

    public void SetLoggerVerbosity(LoggerVerbosity verbosity);
}
