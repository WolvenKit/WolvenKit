using System.Diagnostics;
using System.Reflection;

namespace WolvenKit.RED4.Types;

public static class CHandle
{
    public static IRedBaseHandle Parse(Type handleType, RedBaseClass? value)
    {
        var method = typeof(CHandle).GetMethod(nameof(Parse), BindingFlags.Public | BindingFlags.Static, null, new[] { typeof(RedBaseClass) }, null);
        if (method == null)
        {
            throw new MissingMethodException(nameof(CHandle), nameof(Parse));
        }

        var generic = method.MakeGenericMethod(handleType);
        if (generic.Invoke(null, new object[] { value }) is not IRedBaseHandle result)
        {
            throw new Exception();
        }

        return result;
    }

    public static CHandle<T> Parse<T>(RedBaseClass? value) where T : RedBaseClass
    {
        return new CHandle<T>((T?)value);
    }
}

[RED("handle")]
public class CHandle<T> : IRedHandle<T>, IEquatable<CHandle<T>>, IRedCloneable where T : RedBaseClass
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

    public CHandle() {}
    public CHandle(RedBaseClass? chunk) => SetValue(chunk);


    public static implicit operator CHandle<T>(T value) => new(value);
    public static implicit operator T?(CHandle<T> value) => value.Chunk;


    public bool IsDynamicClass => DynamicChunk != null;
    

    public bool Equals(CHandle<T>? other)
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

        return Equals((CHandle<T>)obj);
    }

    public override int GetHashCode() => EqualityComparer<T>.Default.GetHashCode(Chunk);

    public object ShallowCopy() => MemberwiseClone();

    public object DeepCopy()
    {
        if (Chunk != null)
        {
            return new CHandle<T>((T)Chunk.DeepCopy());
        }
        return new CHandle<T>();
    }
}