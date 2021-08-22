using System.IO;

namespace WolvenKit.RED4.TweakDB.Types
{
    public class CInt32 : BaseFundamental<int>
    {
        public override string Name => "Int32";

        public static implicit operator CInt32(int value) => new() { Value = value };

        public override void Serialize(BinaryWriter writer) => writer.Write(Value);
    }
}
