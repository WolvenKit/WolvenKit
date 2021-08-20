using System.IO;

namespace WolvenKit.RED4.TweakDB.Types
{
    public class CInt16 : BaseFundamental<short>
    {
        public override string Name => "Int16";

        public override void Serialize(BinaryWriter writer) => writer.Write(Value);
    }
}
