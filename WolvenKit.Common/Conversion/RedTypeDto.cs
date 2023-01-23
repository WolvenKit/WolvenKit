using WolvenKit.RED4.Types;

namespace WolvenKit.Common.Conversion;

public class RedTypeDto
{
    public RedTypeDto()
    {

    }

    public RedTypeDto(IRedType cls) => Data = cls;

    public JsonHeader Header { get; set; } = new();
    public IRedType? Data { get; set; }
}
