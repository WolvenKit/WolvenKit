using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.Save;

public struct CyberpunkSaveHeaderStruct
{
    public uint SaveVersion;
    public uint GameVersion;
    public string GameDefPath;
    public ulong TimeStamp;
    public uint ArchiveVersion;

    public static CyberpunkSaveHeaderStruct Read(BinaryReader reader) =>
        new()
        {
            SaveVersion = reader.ReadUInt32(),
            GameVersion = reader.ReadUInt32(),
            GameDefPath = reader.ReadLengthPrefixedString(),
            TimeStamp = reader.ReadUInt64(),
            ArchiveVersion = reader.ReadUInt32()
        };

    public void Write(BinaryWriter writer)
    {
        writer.Write(SaveVersion);
        writer.Write(GameVersion);
        writer.WriteLengthPrefixedString(GameDefPath);
        writer.Write(TimeStamp);
        writer.Write(ArchiveVersion);
    }
}
