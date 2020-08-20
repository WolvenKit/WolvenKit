using W3SavegameEditor.Core.Savegame.Attributes;

namespace W3SavegameEditor.Core.Savegame.Values.Quests
{
    [CSerializable("conditions")]
    public class QuestConditions
    {
        public QuestConditions()
        {
            
        }

        [CArray("numConditions", ElementName = "p")]
        public QuestCondition[] Conditions { get; set; }
    }
}