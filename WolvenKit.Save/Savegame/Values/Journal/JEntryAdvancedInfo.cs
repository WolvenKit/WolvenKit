using W3SavegameEditor.Core.Savegame.Attributes;

namespace W3SavegameEditor.Core.Savegame.Values.Journal
{
    public class JEntryAdvancedInfo
    {
        [CName("Size")]
        public uint Size { get; set; }

        [CName("JEntryAdvancedInfoGuid")]
        public JEntryAdvancedInfoGuid[] JEntryAdvancedInfoGuid { get; set; }
    }
}