namespace WolvenKit.RED4.Types
{
    public class CWeakHandle<T> : IRedHandle<T> where T : IRedClass
    {
        public int Pointer { get; set; }
        public void SetValue(int value) => Pointer = value;
    }
}
