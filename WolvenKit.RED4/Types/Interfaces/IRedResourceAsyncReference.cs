namespace WolvenKit.RED4.Types;

public interface IRedResourceAsyncReference : IRedRef
{
        
}

public interface IRedResourceAsyncReference<T> : IRedResourceAsyncReference, IRedType<T>, IRedGenericType<T>
{

}