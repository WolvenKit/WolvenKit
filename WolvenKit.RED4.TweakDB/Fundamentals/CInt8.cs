using System.IO;

namespace WolvenKit.RED4.TweakDB
{
    public class CInt8 : BaseFundamental<sbyte>
    {
        public override string Name => "Int8";

        public override void Serialize(BinaryWriter writer) => writer.Write(Value);
    }
}
