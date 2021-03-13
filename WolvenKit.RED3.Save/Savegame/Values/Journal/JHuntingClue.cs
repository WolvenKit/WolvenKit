using System;
using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values.Journal
{
    public class JHuntingClue
    {
        #region Properties

        [CName("JHuntingQuestGuid")]
        public Guid HuntingQuestGuid { get; set; }

        [CName("Size")]
        public uint Size { get; set; }

        #endregion Properties
    }
}
