using System.Collections.Generic;
using System;
using System.Linq;

namespace WolvenKit.Common.Model.Arguments;

public abstract class AbstractGlobalArgs
{
    protected readonly Dictionary<Type, ImportExportArgs> _argsList = new();

    /// <summary>
    /// Register Export Arguments.
    /// </summary>
    /// <param name="exportArgs"></param>
    /// <returns></returns>
    public AbstractGlobalArgs Register(params ImportExportArgs[] args)
    {
        foreach (var arg in args)
        {
            _argsList[arg.GetType()] = arg;
        }

        return this;
    }

    /// <summary>
    /// Get Argument.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public T Get<T>() where T : ImportExportArgs
    {
        var arg = _argsList[typeof(T)];
        if (arg is T t)
        {
            return t;
        }
        throw new ArgumentException();
    }

    public ImportExportArgs Get(Type type) => _argsList[type];

    public IList<Type> GetTypes() => _argsList.Keys.ToList();
}