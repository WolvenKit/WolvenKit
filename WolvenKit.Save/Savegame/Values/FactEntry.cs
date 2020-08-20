using W3SavegameEditor.Core.Savegame.Attributes;

namespace W3SavegameEditor.Core.Savegame.Values
{
    [CSerializable("entry")]
    public class FactEntry
    {
        [CName("value")]
        public int Value { get; set; }
        [CName("time")]
        public double Time { get; set; }
        [CName("expiryTime")]
        public double ExpiryTime { get; set; }
    }
}