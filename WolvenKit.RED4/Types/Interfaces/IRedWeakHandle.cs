namespace WolvenKit.RED4.Types;

public interface IRedWeakHandle : IRedBaseHandle, IRedType
{
}

public interface IRedWeakHandle<T> : IRedWeakHandle, IRedBaseHandle<T>, IRedGenericType<T> where T : RedBaseClass
{

}