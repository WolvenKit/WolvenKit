using System.IO;
using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.TweakDB.Types
{
    public class CName : IType
    {
        public string Name => "CName";
        public string Text { get; set; }

        public static implicit operator CName(string value) => new() { Text = value };

        public override string ToString() => $"CName, Text = '{Text}'";

        public void Serialize(BinaryWriter writer) => writer.WriteLengthPrefixedString(Text);
    }
}
