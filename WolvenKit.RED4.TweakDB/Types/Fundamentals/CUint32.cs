using System.IO;

namespace WolvenKit.RED4.TweakDB.Types
{
    public class CUint32 : BaseFundamental<uint>
    {
        public override string Name => "Uint32";

        public static implicit operator CUint32(uint value) => new() { Value = value };

        public override void Serialize(BinaryWriter writer) => writer.Write(Value);
    }
}
