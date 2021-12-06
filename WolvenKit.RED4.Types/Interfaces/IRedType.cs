using System;
using System.Diagnostics;

namespace WolvenKit.RED4.Types
{
    public interface IRedType
    {
        public string RedType => RedReflection.GetTypeRedName(GetType());
    }

    public interface IRedType<T> : IRedType
    {
    }

    public interface IRedGenericType : IRedType
    {
    }

    public interface IRedGenericType<T> : IRedGenericType
    {
    }
}
