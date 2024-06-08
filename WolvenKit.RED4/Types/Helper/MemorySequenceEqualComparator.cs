namespace WolvenKit.RED4.Types;

public class MemorySequenceEqualComparator : IEqualityComparer<ReadOnlyMemory<char>>
{
    public static readonly MemorySequenceEqualComparator Instance = new();
    
    private MemorySequenceEqualComparator() {}
    
    public bool Equals(ReadOnlyMemory<char> x, ReadOnlyMemory<char> y) => 
        x.Length == y.Length && x.Span.SequenceEqual(y.Span);

    public int GetHashCode(ReadOnlyMemory<char> obj) =>
        obj.GetHashCode();
}
