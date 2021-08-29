using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace WolvenKit.RED4.Types
{
    public class CArray<T> : IRedArray<T> where T : IRedType
    {
        public List<T> Value { get; set; } = new();

        public void Add(object value) => Value.Add((T)value);
    }
}
