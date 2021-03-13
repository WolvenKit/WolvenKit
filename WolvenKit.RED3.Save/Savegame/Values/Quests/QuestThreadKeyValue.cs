using System;
using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values.Quests
{
    [CSerializable("questThreadKeyValue", Custom = true)]
    public class QuestThreadKeyValue
    {
        #region Constructors

        public QuestThreadKeyValue()
        {
        }

        #endregion Constructors

        #region Properties

        [CName("GUID")]
        public Guid Guid { get; set; }

        [CName("questThread")]
        public QuestThread Thread { get; set; }

        #endregion Properties
    }
}
