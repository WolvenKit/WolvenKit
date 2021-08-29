using System.Collections.Generic;

namespace WolvenKit.RED4.Types
{
    public class CStatic<T> : IRedArray<T> where T : IRedType
    {
        public List<T> Value { get; set; } = new();

        public void Add(object value) => Value.Add((T)value);
    }
}
