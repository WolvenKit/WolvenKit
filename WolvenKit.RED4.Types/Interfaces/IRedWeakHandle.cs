namespace WolvenKit.RED4.Types
{
    public interface IRedWeakHandle : IRedType
    {
        public int GetValue();
        public void SetValue(int value);
    }

    public interface IRedWeakHandle<T> : IRedWeakHandle, IRedGenericType<T>
    {

    }
}
