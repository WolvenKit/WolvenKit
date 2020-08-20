using W3SavegameEditor.Core.Savegame.Attributes;

namespace W3SavegameEditor.Core.Savegame.Values.Journal
{
    public class JHuntingClues
    {
        [CName("Size")]
        public uint Size { get; set; }

        public JHuntingClue[] Clues { get; set; }
    }
}