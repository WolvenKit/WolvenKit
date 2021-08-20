using System.IO;

namespace WolvenKit.RED4.TweakDB
{
    public class CFloat : BaseFundamental<float>
    {
        public override string Name => "Float";

        public override void Serialize(BinaryWriter writer) => writer.Write(Value);
    }
}
