using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values.Gwint
{
    public class GwintDeck
    {
        #region Properties

        [CName("CardCount")]
        public uint CardCount { get; set; }

        [CName("DeckUnlocked")]
        public bool DeckUnlocked { get; set; }

        public GwintDeckCard[] GwintDeckCards { get; set; }

        [CName("LeaderIndex")]
        public int LeaderIndex { get; set; }

        #endregion Properties
    }
}
