namespace WolvenKit.Common.Model;

public class RedTypeTemplate
{
    public int Version { get; set; }
    public object? Data { get; set; }

    public RedTypeTemplate()
    {
        Version = 1;
    }
}
