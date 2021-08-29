using System;
using System.Diagnostics;

namespace WolvenKit.RED4.Types
{
    public interface IRedType
    {
    }

    public interface IRedType<T> : IRedType
    {
        T Value { get; set; }
    }
}
