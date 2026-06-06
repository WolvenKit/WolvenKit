using WolvenKit.RED4.Types;

namespace WolvenKit.Common.Model;

public class RedTypeTemplate
{
    public int Version { get; set; }
    public RedBaseClass? Data { get; set; }

    public RedTypeTemplate()
    {
        Version = 1;
    }
}
