using System.Collections.Generic;
using WolvenKit.RED4.TweakDB.Types;

namespace WolvenKit.RED4.TweakDB
{
    public sealed class Record
    {
        public string Type { get; set; }

        public string Inherits { get; set; }

        public Dictionary<string, IType> Members { get; set; } = new();

        public override string ToString() => $"[:{Inherits}] {string.Join(',', Members.Keys)}";
    }
}
