using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values.Journal
{
    public class JHuntingClues
    {
        #region Properties

        public JHuntingClue[] Clues { get; set; }

        [CName("Size")]
        public uint Size { get; set; }

        #endregion Properties
    }
}
