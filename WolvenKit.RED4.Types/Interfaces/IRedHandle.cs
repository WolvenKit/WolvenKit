namespace WolvenKit.RED4.Types
{
    public interface IRedHandle : IRedType
    {
        public int GetValue();
        public void SetValue(int value);
    }

    public interface IRedHandle<T> : IRedPrimitive<T>, IRedHandle
    {

    }
}
