using System.Diagnostics;
using System.IO;
using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.TweakDB.Types
{
    [DebuggerDisplay("{Text}")]
    public class CString : IType
    {
        public string Name => "String";
        public string Text { get; set; }

        public void Serialize(BinaryWriter writer) => writer.WriteLengthPrefixedString(Text);
    }
}
