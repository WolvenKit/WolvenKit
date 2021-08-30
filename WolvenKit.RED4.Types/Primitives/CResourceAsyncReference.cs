namespace WolvenKit.RED4.Types
{
    public class CResourceAsyncReference<T> : IRedResourceReference<T> where T : IRedType
    {
        public ushort Value { get; set; }

        public ushort GetValue() => Value;
        public void SetValue(ushort value) => Value = value;
    }
}
