using System;
using System.Collections;
using System.Collections.Generic;

namespace WolvenKit.RED4.Types
{
    public interface IRedBaseHandle
    {
        public Type InnerType { get; }

        public RedBaseClass GetValue();
        public void SetValue(RedBaseClass cls);
    }

    public interface IRedBaseHandle<T> : IRedBaseHandle where T : RedBaseClass
    {
        //Red4File File { get; }
    }

    public interface IRedHandle : IRedBaseHandle, IRedType
    {
    }

    public interface IRedHandle<T> : IRedHandle, IRedBaseHandle<T>, IRedGenericType<T> where T : RedBaseClass
    {
    }
}
