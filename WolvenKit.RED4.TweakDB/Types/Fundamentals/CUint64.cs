using System.IO;

namespace WolvenKit.RED4.TweakDB.Types
{
    public class CUint64 : BaseFundamental<ulong>
    {
        public override string Name => "Uint64";

        public override void Serialize(BinaryWriter writer) => writer.Write(Value);
    }
}
