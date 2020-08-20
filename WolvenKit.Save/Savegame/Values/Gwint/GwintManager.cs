using W3SavegameEditor.Core.Savegame.Attributes;

namespace W3SavegameEditor.Core.Savegame.Values.Gwint
{
    [CName("CR4GwintManager")]
    public class GwintManager
    {
        [CName("SBCollectionCardSize")]
        public CollectionSize CollectionCardSize { get; set; }

        public CollectionCard[] CollectionCards { get; set; }

        [CName("SBLeaderCollectionCardSize")]
        public CollectionSize LeaderCollectionCardSize { get; set; }

        public CollectionCard[] LeaderCollectionCards { get; set; }

        [CName("SBSelectedDeckIndex")]
        public SelectedDeckIndex SelectedDeckIndex { get; set; }

        [CName("GwintDecks")]
        public GwintDecks GwintDecks { get; set; }

        [CName("GwintTutorialsDone")]
        public bool GwintTutorialsDone { get; set; }

        [CName("GwintDeckTutorialsDone")]
        public bool GwintDeckTutorialsDone { get; set; }
    }
}