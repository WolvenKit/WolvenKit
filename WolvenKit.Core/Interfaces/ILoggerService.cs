using System;
using Microsoft.Build.Framework;

namespace WolvenKit.Core.Interfaces;

public interface ILoggerService
{
    public void Info(string s);

    public void Warning(string s);

    public void Error(string msg);

    public void Success(string msg);

    public void Debug(string msg);


    public void Error(Exception exception);

    public LoggerVerbosity LoggerVerbosity { get; }

    public void SetLoggerVerbosity(LoggerVerbosity verbosity);
}