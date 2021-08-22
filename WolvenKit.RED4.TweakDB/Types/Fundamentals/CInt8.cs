using System.IO;

namespace WolvenKit.RED4.TweakDB.Types
{
    public class CInt8 : BaseFundamental<sbyte>
    {
        public override string Name => "Int8";

        public static implicit operator CInt8(sbyte value) => new() { Value = value };

        public override void Serialize(BinaryWriter writer) => writer.Write(Value);
    }
}
