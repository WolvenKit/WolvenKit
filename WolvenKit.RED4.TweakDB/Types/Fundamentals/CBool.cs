using System.IO;

namespace WolvenKit.RED4.TweakDB.Types
{
    public class CBool : BaseFundamental<bool>
    {
        public override string Name => "Bool";

        public override void Serialize(BinaryWriter writer) => writer.Write(Value);
    }
}
