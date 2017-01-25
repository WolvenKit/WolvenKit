using W3SavegameEditor.Core.Savegame.Attributes;

namespace W3SavegameEditor.Core.Savegame.Values.Gwint
{
    public class SelectedDeckIndex  
    {
        [CName("deckIndex")]
        [EnumName("eGwintFaction")]
        public W3Enum DeckIndex { get; set; }
    }
}