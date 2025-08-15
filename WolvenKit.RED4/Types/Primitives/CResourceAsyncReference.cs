using WolvenKit.Common.FNV1A;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Types;

[RED("raRef")]
public readonly struct CResourceAsyncReference<T> : IRedResourceAsyncReference<T>, IEquatable<CResourceAsyncReference<T>> where T : CResource
{
    private readonly ResourcePath _depotPath;
    private readonly InternalEnums.EImportFlags _flags;


    public CResourceAsyncReference()
    {
        _depotPath = ResourcePath.Empty;
        _flags = InternalEnums.EImportFlags.Soft;
    }

    public CResourceAsyncReference(ResourcePath depotPath)
    {
        _depotPath = depotPath;
        _flags = InternalEnums.EImportFlags.Soft;
    }

    public CResourceAsyncReference(ResourcePath depotPath, InternalEnums.EImportFlags flags)
    {
        _depotPath = depotPath;
        _flags = flags;
    }

    public ResourcePath DepotPath => _depotPath;
    public InternalEnums.EImportFlags Flags => _flags;

    public bool IsSet => _depotPath != ResourcePath.Empty;

    public bool Equals(CResourceAsyncReference<T> other)
    {
        if (!Equals(_depotPath, other._depotPath))
        {
            return false;
        }

        if (!Equals(_flags, other._flags))
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

        if (obj.GetType() != GetType())
        {
            return false;
        }

        return Equals((CResourceAsyncReference<T>)obj);
    }

    public override int GetHashCode() => HashCode.Combine(_depotPath, (int)_flags);

    public uint GetPersistentHash()
    {
        NotResolvableException.ThrowIfNotResolvable(_depotPath);

        using (var fnv = new FNV1A32HashAlgorithm())
        {
            fnv.AppendString(_depotPath!);
            fnv.AppendString(_flags.ToString());

            return fnv.HashUInt32;
        }
    }

    public override string ToString() => $"{_depotPath} <{RedReflection.GetRedTypeFromCSType(GetType())} 0x{_depotPath.GetRedHash():X} / {_depotPath.GetRedHash()}>";
}