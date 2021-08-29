using System.Collections.Generic;

namespace WolvenKit.RED4.Types
{
    public interface IRedArray
    {
        public void Add(object value);
    }

    public interface IRedArray<T> : IRedPrimitive<T>, IRedArray
    {
        public List<T> Value { get; set; }
    }
}
