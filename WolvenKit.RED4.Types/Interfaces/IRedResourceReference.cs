namespace WolvenKit.RED4.Types
{
    public interface IRedResourceReference : IRedRef
    {
        
    }

    public interface IRedResourceReference<T> : IRedResourceReference, IRedType<T>, IRedGenericType<T>
    {

    }
}
