using System.IO;

namespace WolvenKit.RED4.Types
{
    public class CBool : BaseFundamental<bool>
    {
        public static implicit operator CBool(bool value) => new() { Value = value };
        public static implicit operator bool(CBool value) => value.Value;
    }
}
