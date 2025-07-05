using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.Buffer;

public class CR2WWrapper : IParseableBuffer
{
    public CR2WFile File { get; set; } = null!;
    public IRedType Data => File.RootChunk;
}