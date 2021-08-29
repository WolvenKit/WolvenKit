namespace WolvenKit.RED4.Types
{
    public class CRUID : IRedPrimitive
    {
        public ulong Value { get; set; }

        public static implicit operator CRUID(ulong value) => new() { Value = value };
        public static implicit operator ulong(CRUID value) => value.Value;
    }
}
