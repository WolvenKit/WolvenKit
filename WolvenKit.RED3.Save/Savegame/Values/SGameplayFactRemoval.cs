using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values
{
    public class SGameplayFactRemoval
    {
        #region Properties

        [CName("factName")]
        public string FactName { get; set; }

        [CName("timerID")]
        public int TimerId { get; set; }

        [CName("value")]
        public int Value { get; set; }

        #endregion Properties
    }
}
