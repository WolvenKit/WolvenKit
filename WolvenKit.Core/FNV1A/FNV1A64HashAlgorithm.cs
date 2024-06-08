using System;
using System.Buffers;
using System.Security.Cryptography;
using System.Text;

namespace WolvenKit.Common.FNV1A;

/// <summary>
/// Hash algorithm, Fowler–Noll–Vo
/// </summary>
public sealed class FNV1A64HashAlgorithm : HashAlgorithm
{
    #region Fields

    private const ulong FnvHashInitial = 0xCBF29CE484222325;
    private const ulong FnvHashPrime = 0x00000100000001B3;
    private readonly Encoding encoding;
    private ulong fnvhash;

    #endregion Fields

    #region Constructors

    public FNV1A64HashAlgorithm(Encoding encoding)
    {
        Initialize();
        HashSizeValue = 64;
        this.encoding = encoding;
    }

    #endregion Constructors

    #region Properties

    public ulong HashUInt64 => fnvhash == FnvHashInitial ? 0 : fnvhash;

    #endregion Properties

    #region Methods

    public static ulong HashReadOnlySpan(ReadOnlySpan<char> source)
    {
        var hash = FnvHashInitial;
        foreach (var b in source)
        {
            unchecked
            {
                hash = (hash ^ b) * FnvHashPrime;
            }
        }

        return hash;
    }

    public static ulong HashReadOnlySpan(ReadOnlySpan<byte> source)
    {
        var hash = FnvHashInitial;
            
        foreach (var b in source)
        {
            unchecked
            {
                hash = (hash ^ b) * FnvHashPrime;
            }
        }

        return hash;
    }

    public static ulong HashReadOnlySpan(ReadOnlySpan<sbyte> source)
    {
        var hash = FnvHashInitial;
            
        foreach (var b in source)
        {
            unchecked
            {
                hash = (hash ^ (ulong)b) * FnvHashPrime;
            }
        }

        return hash;
    }

    public static ulong HashString(string value) => HashString(value, Encoding.ASCII);

    public static ulong HashString(string value, Encoding encoding, bool nullEnded = false, bool useSignedBuffer = false) => 
        HashString(value.AsSpan(), encoding, nullEnded, useSignedBuffer);

    public static ulong HashString(ReadOnlySpan<char> value, Encoding encoding, bool nullEnded = false, bool useSignedBuffer = false)
    {
        var length = encoding.GetMaxByteCount(nullEnded ? value.Length + 1 : value.Length);
        var buffer = ArrayPool<byte>.Shared.Rent(length);
        try
        {
            var encodedLength = encoding.GetBytes(value, buffer.AsSpan());

            if (nullEnded)
            {
                buffer[encodedLength] = 0;
                encodedLength++;
            }

            if (useSignedBuffer)
            {
                var signedBuffer = (sbyte[])(Array)buffer;
                return HashReadOnlySpan(new ReadOnlySpan<sbyte>(signedBuffer, 0, encodedLength));
            }
            else
            {
                return HashReadOnlySpan(new ReadOnlySpan<byte>(buffer, 0, encodedLength));
            }
        }
        finally
        {
            ArrayPool<byte>.Shared.Return(buffer);
        }
    }

    public static ulong HashStringWithoutAliases(ReadOnlySpan<char> value)
    {
        if (value.Length == 0)
            return 0;

        var hash = FnvHashInitial;

        for (var i = 0; i < value.Length; i++)
        {
            if (value[i] == '#')
                ++i;

            if (value[i] == ';')
            {
                var nextSlash = value[i..].IndexOf('/');
                
                if (nextSlash == -1) // '/' not found after ";"
                {
                    i = value.Length; // moveTo the end of the string
                }
                else
                {
                    i += nextSlash; // move to the position of the next "/"
                }
            }

            // to avoid the index out of range error in case we moved to the end at previous steps 
            if(i < value.Length)
            {
                unchecked { 
                    hash = (hash ^ value[i]) * FnvHashPrime; 
                }
            }
        }

        return hash;
    }
    
    public void AppendString(string value) => AppendString(value, false);

    public void AppendString(string value, bool nullEnded)
    {
        if (string.IsNullOrEmpty(value))
        {
            return;
        }

        var length = encoding.GetMaxByteCount(nullEnded ? value.Length + 1 : value.Length);
        var buffer = ArrayPool<byte>.Shared.Rent(length);
        try
        {
            var encodedLength = encoding.GetBytes(value.AsSpan(), buffer.AsSpan());
            if (nullEnded)
            {
                buffer[encodedLength] = 0;
                encodedLength++;
            }

            HashCore(buffer, 0, encodedLength);
        }
        finally
        {
            ArrayPool<byte>.Shared.Return(buffer);
        }
    }

    public override void Initialize() => fnvhash = FnvHashInitial;

    protected override void HashCore(byte[] array, int ibStart, int cbSize)
    {
        if (array == null)
        {
            throw new ArgumentNullException(nameof(array));
        }

        var ibEnd = ibStart + cbSize;
        if (ibEnd > array.Length)
        {
            throw new IndexOutOfRangeException();
        }

        unchecked
        {
            for (var i = ibStart; i < ibEnd; i++)
            {
                fnvhash = (fnvhash ^ array[i]) * FnvHashPrime;
            }
        }
    }

    protected override byte[] HashFinal() => BitConverter.GetBytes(HashUInt64);

    #endregion Methods
}