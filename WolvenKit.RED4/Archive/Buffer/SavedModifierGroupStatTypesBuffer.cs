using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.Buffer;

public class SavedModifierGroupStatTypesBuffer : IParseableBuffer
{
    public IRedType? Data => null;

    public bool IsParsed { get; set; } = true;
    public List<SavedModifierGroupStatTypesBuffer_Entry> Entries { get; set; } = new();
}

public class SavedModifierGroupStatTypesBuffer_Entry
{
    public uint ModifierGroupHash { get; set; } // TweakDBID but just the crc part...
    public List<Enums.gamedataStatType> StatTypes { get; set; } = new();
}