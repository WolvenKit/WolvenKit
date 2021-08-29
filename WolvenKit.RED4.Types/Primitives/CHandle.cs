namespace WolvenKit.RED4.Types
{
    public class CHandle<T> : IRedHandle<T> where T : IRedClass
    {
        public int Pointer { get; set; }
        public void SetValue(int value) => Pointer = value;
    }
}
