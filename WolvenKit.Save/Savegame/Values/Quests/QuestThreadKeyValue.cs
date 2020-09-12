using System;
using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values.Quests
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