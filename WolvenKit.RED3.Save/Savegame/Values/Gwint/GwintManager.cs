using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values.Gwint
{
    [CName("CR4GwintManager")]
    public class GwintManager
    {
        #region Properties

        public CollectionCard[] CollectionCards { get; set; }

        [CName("SBCollectionCardSize")]
        public CollectionSize CollectionCardSize { get; set; }

        [CName("GwintDecks")]
        public GwintDecks GwintDecks { get; set; }

        [CName("GwintDeckTutorialsDone")]
        public bool GwintDeckTutorialsDone { get; set; }

        [CName("GwintTutorialsDone")]
        public bool GwintTutorialsDone { get; set; }

        public CollectionCard[] LeaderCollectionCards { get; set; }

        [CName("SBLeaderCollectionCardSize")]
        public CollectionSize LeaderCollectionCardSize { get; set; }

        [CName("SBSelectedDeckIndex")]
        public SelectedDeckIndex SelectedDeckIndex { get; set; }

        #endregion Properties
    }
}
