using System.Diagnostics;
using System.Reflection;

namespace WolvenKit.RED4.Types;

public static class CWeakHandle
{
    public static IRedBaseHandle Parse(Type handleType, RedBaseClass? value)
    {
        var method = typeof(CWeakHandle).GetMethod(nameof(Parse), BindingFlags.Public | BindingFlags.Static, null, new[] { typeof(RedBaseClass) }, null);
        if (method == null)
        {
            throw new MissingMethodException(nameof(CWeakHandle), nameof(Parse));
        }

        var generic = method.MakeGenericMethod(handleType);
        if (generic.Invoke(null, new object[] { value }) is not IRedBaseHandle result)
        {
            throw new Exception();
        }

        return result;
    }

    public static CWeakHandle<T> Parse<T>(RedBaseClass? value) where T : RedBaseClass
    {
        return new CWeakHandle<T>((T?)value);
    }
}

[RED("whandle")]
public class CWeakHandle<T> : IRedWeakHandle<T>, IEquatable<CWeakHandle<T>> where T : RedBaseClass
{
    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public T? Chunk { get; set; }

    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public DynamicBaseClass? DynamicChunk { get; set; }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public Type InnerType => typeof(T);


    public RedBaseClass? GetValue()
    {
        if (IsDynamicClass)
        {
            return DynamicChunk;
        }
        return Chunk;
    }

    public void SetValue(RedBaseClass? cls)
    {
        if (cls is DynamicBaseClass dbc)
        {
            DynamicChunk = dbc;
        }
        else
        {
            Chunk = (T?)cls;
        }
    }


    public CWeakHandle() {}
    public CWeakHandle(RedBaseClass? chunk) => SetValue(chunk);


    public static implicit operator CWeakHandle<T>(T value) => new(value);
    public static implicit operator T?(CWeakHandle<T> value) => value.Chunk;


    public bool IsDynamicClass => DynamicChunk != null;


    public bool Equals(CWeakHandle<T>? other)
    {
        if (ReferenceEquals(null, other))
        {
            return false;
        }

        if (ReferenceEquals(this, other))
        {
            return true;
        }

        if (!Equals(Chunk, other.Chunk))
        {
            return false;
        }

        return true;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj))
        {
            return false;
        }

        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        if (obj.GetType() != this.GetType())
        {
            return false;
        }

        return Equals((CWeakHandle<T>)obj);
    }

    public override int GetHashCode() => EqualityComparer<T>.Default.GetHashCode((T)Chunk);
}