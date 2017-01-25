using W3SavegameEditor.Core.Savegame.Attributes;

namespace W3SavegameEditor.Core.Savegame.Values.Journal
{
    public class JMonsterKnown
    {
        [CName("Size")]
        public uint Size { get; set; }
        
        [CName("JMonsterKnownGuid")]
        public JMonsterKnownGuid[] MonsterKnownGuid { get; set; }
    }
}