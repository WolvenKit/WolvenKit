using System.Collections.Generic;
using WolvenKit.RED4.TweakDB;
using WolvenKit.RED4.Types;

namespace WolvenKit.Modkit.RED4.Serialization
{
    public sealed class TweakDocument
    {
        public Dictionary<string, IRedType> Flats { get; set; } = new();
        public Dictionary<string, gamedataTweakDBRecord> Groups { get; set; } = new();
    }
}
