using System.IO;

namespace WolvenKit.RED4.TweakDB.Types
{
    public class CFloat : BaseFundamental<float>
    {
        public override string Name => "Float";

        public static implicit operator CFloat(float value) => new() { Value = value };

        public override void Serialize(BinaryWriter writer) => writer.Write(Value);
    }
}
