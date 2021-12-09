using System;
using System.Collections;
using System.Collections.Generic;

namespace WolvenKit.RED4.Types
{
    public interface IRedRemoveable
    {
        public void Remove();
    }

    public interface IRedBaseHandle : IRedRemoveable
    {
        public Red4File File { get; }
        public int Pointer { get; set; }
        public Type InnerType {
            get
            {
                return File?.Chunks?[Pointer]?.GetType() ?? null;
            }
        }
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
