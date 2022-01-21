using WolvenKit.RED4.Archive;

namespace WolvenKit.Common.Conversion;

public class RedEmbeddedDto
{
    public RedEmbeddedDto(ICR2WEmbeddedFile s)
    {
        S = s;
    }

    public ICR2WEmbeddedFile S { get; }
}
