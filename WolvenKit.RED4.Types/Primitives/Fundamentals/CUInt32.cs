using System.IO;

namespace WolvenKit.RED4.Types
{
    public class CUInt32 : BaseFundamental<uint>
    {
        public static implicit operator CUInt32(uint value) => new() { Value = value };
        public static implicit operator uint(CUInt32 value) => value.Value;
    }
}
