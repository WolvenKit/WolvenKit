using System.IO;

namespace WolvenKit.RED4.Types
{
    public class CDouble : BaseFundamental<double>
    {
        public static implicit operator CDouble(double value) => new() { Value = value };
        public static implicit operator double(CDouble value) => value.Value;
    }
}
