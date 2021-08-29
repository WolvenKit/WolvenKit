using System;

namespace WolvenKit.RED4.Types
{
    public interface IRedEnum
    {
        public void SetValue(object value);
    }

    public interface IRedEnum<T> : IRedPrimitive<T>, IRedEnum where T : Enum
    {

    }
}
