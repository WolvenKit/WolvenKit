using System.IO;

namespace WolvenKit.RED4.Types
{
    public class CInt8 : BaseFundamental<sbyte>
    {
        public static implicit operator CInt8(sbyte value) => new() { Value = value };
        public static implicit operator sbyte(CInt8 value) => value.Value;
    }
}
