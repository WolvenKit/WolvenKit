using W3SavegameEditor.Core.Savegame.Attributes;

namespace W3SavegameEditor.Core.Savegame.Values.Gwint
{
    public class GwintDeck
    {
        [CName("DeckUnlocked")]
        public bool DeckUnlocked { get; set; }

        [CName("LeaderIndex")]
        public int LeaderIndex { get; set; }

        [CName("CardCount")]
        public uint CardCount { get; set; }

        public GwintDeckCard[] GwintDeckCards { get; set; }
    }
}