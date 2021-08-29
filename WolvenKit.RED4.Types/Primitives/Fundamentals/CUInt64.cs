using System.IO;

namespace WolvenKit.RED4.Types
{
    public class CUInt64 : BaseFundamental<ulong>
    {
        public static implicit operator CUInt64(ulong value) => new() { Value = value };
        public static implicit operator ulong(CUInt64 value) => value.Value;
    }
}
