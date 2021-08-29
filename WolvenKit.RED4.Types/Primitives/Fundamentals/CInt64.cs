using System.IO;

namespace WolvenKit.RED4.Types
{
    public class CInt64 : BaseFundamental<long>
    {
        public static implicit operator CInt64(long value) => new() { Value = value };
        public static implicit operator long(CInt64 value) => value.Value;
    }
}
