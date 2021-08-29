namespace WolvenKit.RED4.Types
{
    public class TweakDBID : IRedPrimitive
    {
        public ulong Value { get; set; }

        public static implicit operator TweakDBID(ulong value) => new() { Value = value };
        public static implicit operator ulong(TweakDBID value) => value.Value;
    }
}
