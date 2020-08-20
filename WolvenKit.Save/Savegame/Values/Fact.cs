using W3SavegameEditor.Core.Savegame.Attributes;

namespace W3SavegameEditor.Core.Savegame.Values
{
    [CSerializable("fact")]
    public class Fact
    {
        [CName("id")]
        public string Id { get; set; }
        [CName("expiringCount")]
        public uint ExpiringCount { get; set; }
        [CArray("entryCount")]
        public FactEntry[] Entries { get; set; }
    }
}