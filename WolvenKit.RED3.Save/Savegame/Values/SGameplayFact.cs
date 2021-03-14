using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values
{
    [CName("SGameplayFact")]
    public class SGameplayFact
    {
        #region Properties

        [CName("factName")]
        public string FactName { get; set; }

        [CName("value")]
        public int Value { get; set; }

        #endregion Properties
    }
}
