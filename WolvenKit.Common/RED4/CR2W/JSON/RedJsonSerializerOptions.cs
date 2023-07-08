namespace WolvenKit.RED4.CR2W.JSON;

public sealed class RedJsonSerializerOptions
{
    public bool SkipHeader { get; set; } = false;
    public string? JsonVersion { get; set; }
}