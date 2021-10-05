using System.IO;
using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.TweakDB.Types
{
    public class CString : IPrimitive
    {
        public string Name => "String";
        public string Text { get; set; }

        public static implicit operator CString(string value) => new() { Text = value };

        public override string ToString() => Text;

        public void Serialize(BinaryWriter writer) => writer.WriteLengthPrefixedString(Text);
    }
}
