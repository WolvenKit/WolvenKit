using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values.Journal
{
    public class JEntryAdvancedInfo
    {
        #region Properties

        [CName("JEntryAdvancedInfoGuid")]
        public JEntryAdvancedInfoGuid[] JEntryAdvancedInfoGuid { get; set; }

        [CName("Size")]
        public uint Size { get; set; }

        #endregion Properties
    }
}
