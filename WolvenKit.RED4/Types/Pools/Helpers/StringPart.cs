namespace WolvenKit.RED4.Types.Helpers;

using System;

internal class StringPart
{
    private readonly string? _original;
    private readonly ReadOnlyMemory<char>? _originalMemory;
    private readonly int _startIndex;
    private readonly int _length;
    private string? _materialized;

    public StringPart(string original, int startIndex, int length)
    {
        _original = original;
        _startIndex = startIndex;
        _length = length;
    }

    public StringPart(ReadOnlyMemory<char> originalMemory) => _originalMemory = originalMemory;

    public ReadOnlySpan<char> AsSpan() => _original.AsSpan(_startIndex, _length);

    public string Materialize()
    {
        _materialized ??= _original != null ?
            _original.Substring(_startIndex, _length) :
            new string(_originalMemory!.Value.Span);

        return _materialized;
    }
}