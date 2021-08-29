using System.IO;

namespace WolvenKit.RED4.Types
{
    public class CInt16 : BaseFundamental<short>
    {
        public static implicit operator CInt16(short value) => new() { Value = value };
        public static implicit operator short(CInt16 value) => value.Value;
    }
}
