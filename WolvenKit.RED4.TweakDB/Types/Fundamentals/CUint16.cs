using System.IO;

namespace WolvenKit.RED4.TweakDB.Types
{
    public class CUint16 : BaseFundamental<ushort>
    {
        public override string Name => "Uint16";

        public override void Serialize(BinaryWriter writer) => writer.Write(Value);
    }
}
