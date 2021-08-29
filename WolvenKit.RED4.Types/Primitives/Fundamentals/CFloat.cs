using System.IO;

namespace WolvenKit.RED4.Types
{
    public class CFloat : BaseFundamental<float>
    {
        public static implicit operator CFloat(float value) => new() { Value = value };
        public static implicit operator float(CFloat value) => value.Value;
    }
}
