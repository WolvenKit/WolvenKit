using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace WolvenKit.Core.Helpers;

/// <summary>
/// A blittable reference to a UTF-8 string stored inside a <see cref="StringBlob"/>.
/// </summary>
/// <remarks>
/// This is deliberately pointer-free. An array of <see cref="StringRef"/> is invisible to the
/// GC's mark phase, unlike a <c>string[]</c>, which forces every one of its elements to be
/// traced on each gen2 collection. It also costs 8 bytes per entry instead of the ~164 bytes
/// a typical resource-path <see cref="string"/> occupies.
/// </remarks>
public readonly struct StringRef : IEquatable<StringRef>
{
    public readonly int Offset;
    public readonly int Length;

    public StringRef(int offset, int length)
    {
        Offset = offset;
        Length = length;
    }

    public bool Equals(StringRef other) => Offset == other.Offset && Length == other.Length;

    public override bool Equals(object? obj) => obj is StringRef other && Equals(other);

    public override int GetHashCode() => HashCode.Combine(Offset, Length);
}

/// <summary>
/// Owns one contiguous, unmanaged UTF-8 buffer holding many strings back to back.
/// </summary>
/// <remarks>
/// The buffer lives outside the managed heap entirely, so it neither contributes to Large Object
/// Heap fragmentation nor costs anything to mark. Individual strings are materialized on demand
/// via <see cref="GetString(StringRef)"/>; callers that only need to inspect bytes should use
/// <see cref="Slice(StringRef)"/> and allocate nothing at all.
/// </remarks>
public sealed unsafe class StringBlob : IDisposable
{
    /// <summary>Shared zero-length blob. Never owns memory, so disposing it is a no-op.</summary>
    public static readonly StringBlob Empty = new(null, 0);

    private byte* _pointer;
    private readonly int _size;
    private int _disposed;

    private StringBlob(byte* pointer, int size)
    {
        _pointer = pointer;
        _size = size;
    }

    /// <summary>
    /// Allocates an uninitialized unmanaged buffer of <paramref name="size"/> bytes.
    /// The caller is expected to fill it (for example by decompressing straight into
    /// <see cref="Pointer"/>) before handing it to a <see cref="LookupTable"/>.
    /// </summary>
    public static StringBlob Allocate(int size)
    {
        if (size <= 0)
        {
            return Empty;
        }

        return new StringBlob((byte*)NativeMemory.Alloc((nuint)size), size);
    }

    /// <summary>Takes ownership of an already-allocated <see cref="NativeMemory"/> buffer.</summary>
    internal static StringBlob Adopt(byte* pointer, int size) =>
        pointer == null || size <= 0 ? Empty : new StringBlob(pointer, size);

    public int Size => _size;

    public byte* Pointer => _pointer;

    public Span<byte> GetSpan() => new(_pointer, _size);

    public ReadOnlySpan<byte> AsSpan() => new(_pointer, _size);

    public ReadOnlySpan<byte> Slice(int offset, int length) => new(_pointer + offset, length);

    public ReadOnlySpan<byte> Slice(StringRef reference) => new(_pointer + reference.Offset, reference.Length);

    /// <summary>Materializes a <see cref="string"/>. This is the only place strings are created.</summary>
    public string GetString(StringRef reference) =>
        reference.Length == 0 ? string.Empty : Encoding.UTF8.GetString(_pointer + reference.Offset, reference.Length);

    public void Dispose()
    {
        if (_pointer == null || Interlocked.Exchange(ref _disposed, 1) != 0)
        {
            return;
        }

        NativeMemory.Free(_pointer);
        _pointer = null;

        GC.SuppressFinalize(this);
    }

    ~StringBlob() => Dispose();
}

/// <summary>
/// Builds a <see cref="StringBlob"/> incrementally when the source data cannot be used in place
/// (for example length-prefixed data, where the prefixes are interleaved with the payload, or
/// UTF-16 payloads that must be transcoded).
/// </summary>
/// <remarks>
/// Growth happens through <see cref="NativeMemory.Realloc"/>, so the repeated doubling never
/// touches the managed heap and never triggers a gen2 collection the way a growing
/// <c>List&lt;string&gt;</c> backing array does once it crosses the 85 000 byte LOH threshold.
/// </remarks>
public sealed unsafe class StringBlobBuilder : IDisposable
{
    private byte* _buffer;
    private int _capacity;
    private int _length;

    public StringBlobBuilder(int initialCapacity = 64 * 1024)
    {
        _capacity = Math.Max(initialCapacity, 64);
        _buffer = (byte*)NativeMemory.Alloc((nuint)_capacity);
        _length = 0;
    }

    public int Length => _length;

    private void EnsureCapacity(int additional)
    {
        var required = _length + additional;
        if (required <= _capacity)
        {
            return;
        }

        var newCapacity = _capacity;
        while (newCapacity < required)
        {
            newCapacity = newCapacity > int.MaxValue / 2 ? int.MaxValue : newCapacity * 2;
        }

        _buffer = (byte*)NativeMemory.Realloc(_buffer, (nuint)newCapacity);
        _capacity = newCapacity;
    }

    /// <summary>Appends raw UTF-8 bytes verbatim.</summary>
    public StringRef AddUtf8(ReadOnlySpan<byte> utf8)
    {
        EnsureCapacity(utf8.Length);

        var reference = new StringRef(_length, utf8.Length);
        utf8.CopyTo(new Span<byte>(_buffer + _length, utf8.Length));
        _length += utf8.Length;

        return reference;
    }

    /// <summary>Transcodes UTF-16 to UTF-8 and appends it, without materializing a string.</summary>
    public StringRef AddUtf16(ReadOnlySpan<char> chars)
    {
        if (chars.Length == 0)
        {
            return new StringRef(_length, 0);
        }

        EnsureCapacity(Encoding.UTF8.GetMaxByteCount(chars.Length));

        var written = Encoding.UTF8.GetBytes(chars, new Span<byte>(_buffer + _length, _capacity - _length));
        var reference = new StringRef(_length, written);
        _length += written;

        return reference;
    }

    /// <summary>
    /// Transfers ownership of the buffer to a new <see cref="StringBlob"/>, trimmed to the exact
    /// number of bytes written. The builder must not be used afterwards.
    /// </summary>
    public StringBlob Build()
    {
        if (_buffer == null)
        {
            return StringBlob.Empty;
        }

        if (_length == 0)
        {
            NativeMemory.Free(_buffer);
            _buffer = null;
            return StringBlob.Empty;
        }

        if (_length < _capacity)
        {
            _buffer = (byte*)NativeMemory.Realloc(_buffer, (nuint)_length);
            _capacity = _length;
        }

        var blob = StringBlob.Adopt(_buffer, _length);

        // ownership transferred
        _buffer = null;
        _capacity = 0;

        return blob;
    }

    public void Dispose()
    {
        if (_buffer == null)
        {
            return;
        }

        NativeMemory.Free(_buffer);
        _buffer = null;
        _capacity = 0;

        GC.SuppressFinalize(this);
    }

    ~StringBlobBuilder() => Dispose();
}
