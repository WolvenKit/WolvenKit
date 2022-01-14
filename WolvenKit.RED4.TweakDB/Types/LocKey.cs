namespace WolvenKit.RED4.TweakDB.Types
{
    public class LocKey : CUint64
    {
        public override string Name => "gamedataLocKeyWrapper";
        public static implicit operator LocKey(ulong value) => new() { Value = value };
    }
}
