namespace WolvenKit.RED4.Types
{
    public interface IRedResourceReference
    {
        public ushort GetValue();
        public void SetValue(ushort value);
    }

    public interface IRedResourceReference<T> : IRedPrimitive<T>, IRedResourceReference
    {

    }
}
