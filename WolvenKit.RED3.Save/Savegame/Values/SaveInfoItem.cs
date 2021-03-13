using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values
{
    [CSerializable("SaveInfoItem", Custom = true)]
    public class SaveInfoItem
    {
        #region Properties

        [CName("time")]
        public ulong Time { get; set; }

        [CName("type")]
        public byte Type { get; set; }

        [CName("v")]
        public ushort V { get; set; }

        #endregion Properties
    }
}
