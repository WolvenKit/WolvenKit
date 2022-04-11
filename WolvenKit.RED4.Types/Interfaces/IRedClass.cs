using System;

namespace WolvenKit.RED4.Types
{
    public interface IRedOverload
    {
        internal void ConstructorOverload();
    }

    public interface IRedCloneable
    {
        public object ShallowCopy();
        public object DeepCopy();
    }
}
