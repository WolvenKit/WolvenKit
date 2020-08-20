using System;
using W3SavegameEditor.Core.Savegame.Attributes;

namespace W3SavegameEditor.Core.Savegame.Values.Quests
{
    [CSerializable("questThreadKeyValue", Custom = true)]
    public class QuestThreadKeyValue
    {
        public QuestThreadKeyValue()
        {

        }

        [CName("GUID")]
        public Guid Guid { get; set; }

        [CName("questThread")]
        public QuestThread Thread { get; set; }

    }
}