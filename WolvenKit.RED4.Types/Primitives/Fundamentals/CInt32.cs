using System.IO;

namespace WolvenKit.RED4.Types
{
    public class CInt32 : BaseFundamental<int>
    {
        public static implicit operator CInt32(int value) => new() { Value = value };
        public static implicit operator int(CInt32 value) => value.Value;
    }
}
