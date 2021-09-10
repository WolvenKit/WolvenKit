using System.Collections;
using System.Collections.Generic;

namespace WolvenKit.RED4.Types
{
    public interface IRedResourceAsyncReference : IRedType
    {
        public string DepotPath { get; set; }
        public InternalEnums.EImportFlags Flags { get; set; }
    }

    public interface IRedResourceAsyncReference<T> : IRedResourceAsyncReference, IRedType<T>, IRedGenericType<T>
    {

    }
}
