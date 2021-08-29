using System.IO;

namespace WolvenKit.RED4.Types
{
    public class CUInt16 : BaseFundamental<ushort>
    {
        public static implicit operator CUInt16(ushort value) => new() { Value = value };
        public static implicit operator ushort(CUInt16 value) => value.Value;
    }
}
