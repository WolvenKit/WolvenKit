using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values.Journal
{
    public class JMonsterKnown
    {
        #region Properties

        [CName("JMonsterKnownGuid")]
        public JMonsterKnownGuid[] MonsterKnownGuid { get; set; }

        [CName("Size")]
        public uint Size { get; set; }

        #endregion Properties
    }
}
