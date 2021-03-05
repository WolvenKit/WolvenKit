using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values.Quests
{
    [CSerializable("questCondition", Custom = true)]
    public class QuestCondition
    {
        #region Properties

        [CName("active")]
        public bool Active { get; set; }

        [CName("nP")]
        public uint Np { get; set; }

        #endregion Properties
    }
}
