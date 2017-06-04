using W3SavegameEditor.Core.Savegame.Attributes;

namespace W3SavegameEditor.Core.Savegame.Values.Gwint
{
    public class CollectionCard
    {
        [CName("cardIndex")]
        public uint CardIndex { get; set; }

        [CName("numCopies")]
        public uint NumCopies { get; set; }
    }
}