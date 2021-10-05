using System.Collections.Generic;
using WolvenKit.RED4.TweakDB;
using WolvenKit.RED4.TweakDB.Types;

namespace WolvenKit.Modkit.RED4.Serialization
{
    public sealed class TweakDocument
    {
        public Dictionary<string, IType> Flats { get; set; } = new();
        public Dictionary<string, Record> Groups { get; set; } = new();
    }
}
