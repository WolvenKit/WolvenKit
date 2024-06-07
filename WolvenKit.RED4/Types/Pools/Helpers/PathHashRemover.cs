using System.Buffers;

namespace WolvenKit.RED4.Types.Helpers;

internal readonly struct PathHashRemover : IDisposable
{
    private readonly string _original;
    private readonly char[]? _buffer;
    private readonly int _newLength;

    public PathHashRemover(string original)
    {
        _original = original;

        // No hashes in this string - do not do anything
        if (!_original.Contains('#'))
        {
            return;
        }
        
        // We have atleast one hash character
        var originalSpan = original.AsSpan();
        _buffer = ArrayPool<char>.Shared.Rent(originalSpan.Length);

        var currentIndex = 0;
        var startIndex = 0;

        while (startIndex < originalSpan.Length)
        {
            var hashIndex = originalSpan[startIndex..].IndexOf('#');

            if (hashIndex == -1) // No more '#' found
            {
                var remainingSpan = originalSpan[startIndex..];
                remainingSpan.CopyTo(_buffer.AsSpan(currentIndex));
                break;
            }

            // Copy the block of characters before the '#'
            if (hashIndex > 0)
            {
                var blockSpan = originalSpan.Slice(startIndex, hashIndex);
                blockSpan.CopyTo(_buffer.AsSpan(currentIndex));
                currentIndex += blockSpan.Length;
            }

            // Move the start index past the '#'
            startIndex += hashIndex + 1;
        }

        _newLength = original.Count(x => x != '#');
        ArrayPool<char>.Shared.Return(_buffer);
    }

    public ReadOnlySpan<char> Span => _buffer != null ? _buffer.AsSpan(0, _newLength) : _original.AsSpan();
    public ReadOnlyMemory<char> Memory => _buffer?.AsMemory(0, _newLength) ?? _original.AsMemory();

    public void Dispose()
    {
        if(_buffer != null)
            ArrayPool<char>.Shared.Return(_buffer);
    }
}