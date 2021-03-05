using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values
{
    [CSerializable("entry")]
    public class FactEntry
    {
        #region Properties

        [CName("expiryTime")]
        public double ExpiryTime { get; set; }

        [CName("time")]
        public double Time { get; set; }

        [CName("value")]
        public int Value { get; set; }

        #endregion Properties
    }
}
