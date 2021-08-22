using System.IO;
using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.TweakDB.Types
{
    public class CString : IType
    {
        public string Name => "String";
        public string Text { get; set; }

        public static implicit operator CString(string value) => new() { Text = value };

        public override string ToString() => $"String, Text = '{Text}'";

        public void Serialize(BinaryWriter writer) => writer.WriteLengthPrefixedString(Text);
    }
}
