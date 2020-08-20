using W3SavegameEditor.Core.Savegame.Attributes;

namespace W3SavegameEditor.Core.Savegame.Values
{
    [CName("SGameplayFact")]
    public class SGameplayFact
    {
        [CName("factName")]
        public string FactName { get; set; }

        [CName("value")]
        public int Value { get; set; }
    }
}