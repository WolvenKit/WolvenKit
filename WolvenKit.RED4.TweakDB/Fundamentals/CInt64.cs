using System.IO;

namespace WolvenKit.RED4.TweakDB
{
    public class CInt64 : BaseFundamental<long>
    {
        public override string Name => "Int64";

        public override void Serialize(BinaryWriter writer) => writer.Write(Value);
    }
}
