using System;
using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values.Quests
{
    [CSerializable("questBlock")]
    public class QuestBlock
    {
        #region Properties

        [CName("activationState")]
        public int ActivationState { get; set; }

        [CName("conditions")]
        public QuestConditions Conditions { get; set; }

        [CName("GUID")]
        public Guid Guid { get; set; }

        [CArray("inputNamesCount")]
        public string[] InputNames { get; set; }

        [CName("wasInputActivated")]
        public bool WasInputActivated { get; set; }

        [CName("wasOutputActivated")]
        public bool WasOutputActivated { get; set; }

        #endregion Properties

        // TODO: Continue here. This is a VL Variable without properties.
        //[CName("timeRemaining")]
        //public GameTime TimeRemaining { get; set; }
    }
}
