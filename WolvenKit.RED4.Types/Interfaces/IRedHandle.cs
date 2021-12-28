using System;
using System.Collections;
using System.Collections.Generic;

namespace WolvenKit.RED4.Types
{
    public interface IRedBaseHandle
    {
        public Type InnerType { get; }

        public IRedClass GetValue();
        public void SetValue(IRedClass cls);
    }

    public interface IRedBaseHandle<T> : IRedBaseHandle where T : IRedClass
    {
        //Red4File File { get; }
    }

    public interface IRedHandle : IRedBaseHandle, IRedType
    {
    }

    public interface IRedHandle<T> : IRedHandle, IRedBaseHandle<T>, IRedGenericType<T> where T : IRedClass
    {
    }
}
