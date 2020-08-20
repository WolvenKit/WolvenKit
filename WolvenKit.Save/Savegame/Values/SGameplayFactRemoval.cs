using W3SavegameEditor.Core.Savegame.Attributes;

namespace W3SavegameEditor.Core.Savegame.Values
{
    public class SGameplayFactRemoval
    {
        [CName("factName")]
        public string FactName { get; set; }

        [CName("value")]
        public int Value { get; set; }

        [CName("timerID")]
        public int TimerId { get; set; }
    }
}