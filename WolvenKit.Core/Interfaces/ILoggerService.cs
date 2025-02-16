using System;
using WolvenKit.Common;

namespace WolvenKit.Core.Interfaces;

public interface ILoggerService
{
    public void Info(string s);
    public void Info(int id, string s) => Info(s);

    public void Warning(string s);
    public void Warning(int id, string s) => Warning(s);

    public void Error(string msg);
    public void Error(int id, string s) => Error(s);

    public void Success(string msg);
    public void Success(int id, string s) => Success(s);

    public void Debug(string msg);
    public void Debug(int id, string s) => Debug(s);

    public void Error(Exception exception);
    public void Error(int id, Exception exception) => Error(exception);

    
    public LoggerVerbosity LoggerVerbosity { get; }

    public void SetLoggerVerbosity(LoggerVerbosity verbosity);
}
