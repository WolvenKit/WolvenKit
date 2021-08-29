using System.Diagnostics;
using System.IO;

namespace WolvenKit.RED4.Types
{
    [DebuggerDisplay("{Value,nq}")]
    public abstract class BaseFundamental<T> : IRedPrimitive where T : struct
    {
        public T Value { get; set; }
    }
}
