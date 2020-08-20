using W3SavegameEditor.Core.Savegame.Attributes;

namespace W3SavegameEditor.Core.Savegame.Values.Quests
{
    [CSerializable("questCondition", Custom = true)]
    public class QuestCondition
    {
        [CName("nP")]
        public uint Np { get; set; }

        [CName("active")]
        public bool Active { get; set; }
    }
}