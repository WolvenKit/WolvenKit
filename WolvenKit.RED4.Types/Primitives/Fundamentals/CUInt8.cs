using System.IO;

namespace WolvenKit.RED4.Types
{
    public class CUInt8 : BaseFundamental<byte>
    {
        public static implicit operator CUInt8(byte value) => new() { Value = value };
        public static implicit operator byte(CUInt8 value) => value.Value;
    }
}
