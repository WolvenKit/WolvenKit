using System;

namespace WolvenKit.RED4.Types
{
    public interface IRedClass : IEquatable<RedBaseClass>, IRedType
    {
        internal object InternalGetPropertyValue(Type type, string redPropertyName, Flags flags);
        internal void InternalSetPropertyValue(string redPropertyName, object value, bool isNative = true);
    }

    public interface IRedOverload
    {
        internal void ConstructorOverload();
    }

    public interface IRedBuffer
    {
        public byte[] Data { get; set; }
    }
}
