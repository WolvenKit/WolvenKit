using System.Collections.Generic;
using WolvenKit.RED4.TweakDB.Types;

namespace WolvenKit.RED4.TweakDB.Serialization
{
    public sealed class TweakDocument
    {
        public Dictionary<string, IType> Flats { get; set; } = new();
        public Dictionary<string, TweakRecord> Groups { get; set; } = new();
    }
}
