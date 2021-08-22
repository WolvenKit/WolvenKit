using System.IO;

namespace WolvenKit.RED4.TweakDB.Types
{
    public class CUint8 : BaseFundamental<byte>
    {
        public override string Name => "Uint8";

        public static implicit operator CUint8(byte value) => new() { Value = value };

        public override void Serialize(BinaryWriter writer) => writer.Write(Value);
    }
}
