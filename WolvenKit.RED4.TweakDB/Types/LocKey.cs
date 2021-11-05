using System.IO;

namespace WolvenKit.RED4.TweakDB.Types
{
    public class LocKey : CUint64
    {
        public static implicit operator LocKey(ulong value) => new() { Value = value };
        public override string Name => "gamedataLocKeyWrapper";
    }
}
