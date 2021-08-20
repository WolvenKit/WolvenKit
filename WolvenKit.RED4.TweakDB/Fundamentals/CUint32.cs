using System.IO;

namespace WolvenKit.RED4.TweakDB
{
    public class CUint32 : BaseFundamental<uint>
    {
        public override string Name => "Uint32";

        public override void Serialize(BinaryWriter writer) => writer.Write(Value);
    }
}
