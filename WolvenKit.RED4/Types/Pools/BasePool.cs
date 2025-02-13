using System.Collections.Concurrent;
using WolvenKit.Core.Helpers;

namespace WolvenKit.RED4.Types.Pools;

internal class BasePool
{
    private LookupTable _nativePool = new();
    private ConcurrentDictionary<ulong, string> _runtimePool = new();

    private readonly Func<string, string>? _sanitizeStringFunc;
    private readonly Func<string, ulong> _calculateHashFunc;

    public BasePool(Func<string, string>? sanitizeStringFunc, Func<string, ulong> calculateHashFunc)
    {
        _sanitizeStringFunc = sanitizeStringFunc;
        _calculateHashFunc = calculateHashFunc;
    }

    private string SanitizeHash(string value) => _sanitizeStringFunc != null ? _sanitizeStringFunc(value) : value;

    public string? ResolveHash(ulong hash)
    {
        if (_nativePool.TryGetValue(hash, out var value))
        {
            return value;
        }

        if (_runtimePool.TryGetValue(hash, out value))
        {
            return value;
        }

        return null;
    }

    public bool IsNative(ulong hash) => _nativePool.ContainsKey(hash);
    public bool IsNative(string value) => IsNative(_calculateHashFunc(SanitizeHash(value)));

    public bool IsRuntime(ulong hash) => _runtimePool.ContainsKey(hash);
    public bool IsRuntime(string value) => IsRuntime(_calculateHashFunc(SanitizeHash(value)));

    public (bool newRuntime, ulong hash) AddOrGetHash(string value)
    {
        value = SanitizeHash(value);

        var hash = _calculateHashFunc(value);

        var newRuntime = !_nativePool.ContainsKey(hash) && !_runtimePool.ContainsKey(hash);
        if (newRuntime)
        {
            _runtimePool.TryAdd(hash, value);
        }

        return (newRuntime, hash);
    }

    public void SetNative(LookupTable values) => _nativePool = values;
}