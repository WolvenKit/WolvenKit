using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values.Quests
{
    [CSerializable("conditions")]
    public class QuestConditions
    {
        #region Constructors

        public QuestConditions()
        {
        }

        #endregion Constructors

        #region Properties

        [CArray("numConditions", ElementName = "p")]
        public QuestCondition[] Conditions { get; set; }

        #endregion Properties
    }
}
