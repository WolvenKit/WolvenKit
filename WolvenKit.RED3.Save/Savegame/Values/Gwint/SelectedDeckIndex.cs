using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values.Gwint
{
    public class SelectedDeckIndex
    {
        #region Properties

        [CName("deckIndex")]
        [EnumName("eGwintFaction")]
        public W3Enum DeckIndex { get; set; }

        #endregion Properties
    }
}
