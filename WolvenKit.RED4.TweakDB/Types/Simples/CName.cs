using System.Diagnostics;
using System.IO;
using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.TweakDB.Types
{
    [DebuggerDisplay("Name, {Text}")]
    public class CName : IType
    {
        public string Name => "CName";
        public string Text { get; set; }

        public void Serialize(BinaryWriter writer) => writer.WriteLengthPrefixedString(Text);
    }
}
