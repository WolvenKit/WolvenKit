using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values
{
    [CSerializable("fact")]
    public class Fact
    {
        #region Properties

        [CArray("entryCount")]
        public FactEntry[] Entries { get; set; }

        [CName("expiringCount")]
        public uint ExpiringCount { get; set; }

        [CName("id")]
        public string Id { get; set; }

        #endregion Properties
    }
}
