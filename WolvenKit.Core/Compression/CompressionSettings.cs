namespace WolvenKit.Core.Compression;

public sealed class CompressionSettings
{
    private static readonly CompressionSettings s_instance = new();

    public Oodle.CompressionLevel CompressionLevel { get; set; } = Oodle.CompressionLevel.Normal;

    public bool UseOodle { get; set; }

    // Explicit static constructor to tell C# compiler not to mark type as beforefieldinit
    static CompressionSettings()
    {
    }

    private CompressionSettings()
    {
    }

    public static CompressionSettings Get() => s_instance;
}
