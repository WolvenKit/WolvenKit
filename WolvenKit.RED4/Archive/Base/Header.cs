namespace WolvenKit.RED4.Archive;

public class Header
{
    #region Fields

    public const uint MAGIC = 1380009042;
    public const int SIZE = 40;
    public const int EXTENDED_SIZE = 0xAC;

    #endregion Fields

    #region Constructors

    public Header()
    {
        Magic = MAGIC;
        Version = 12;
        DebugPosition = 0;
        DebugSize = 0;
    }

    #endregion Constructors

    #region Properties

    public ulong DebugPosition { get; set; }
    public uint DebugSize { get; set; }
    public ulong Filesize { get; set; }
    public ulong IndexPosition { get; set; }
    public uint IndexSize { get; set; }
    public uint Magic { get; set; }
    public uint Version { get; set; }

    #endregion Properties
}