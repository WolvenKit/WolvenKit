using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values.Gwint
{
    public class CollectionCard
    {
        #region Properties

        [CName("cardIndex")]
        public uint CardIndex { get; set; }

        [CName("numCopies")]
        public uint NumCopies { get; set; }

        #endregion Properties
    }
}
