using System.IO;

namespace WolvenKit.RED4.TweakDB.Types
{
    public class CInt64 : BaseFundamental<long>
    {
        public override string Name => "Int64";

        public static implicit operator CInt64(long value) => new() { Value = value };

        public override void Serialize(BinaryWriter writer) => writer.Write(Value);
    }
}
