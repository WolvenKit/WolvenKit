using WolvenKit.RED4.Types;

namespace WolvenKit.Common.Model;

public class RedTypeTemplate
{
    public int FormatVersion { get; set; }
    public string Author { get; set; }
    public string Description { get; set; }
    public string Version { get; set; }

    public RedBaseClass? Data { get; set; }

    public RedTypeTemplate()
    {
        FormatVersion = 1;

        Author = "";
        Description = "";
        Version = "";
    }
}
