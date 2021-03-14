using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values
{
    [CSerializable("saveInfo")]
    public class SaveInfo
    {
        #region Properties

        [CName("description")]
        public string Description { get; set; }

        [CArray]
        public SaveInfoItem[] Items { get; set; }

        [CName("magic_number")]
        public byte[] MagicNumber { get; set; }

        [CName("runtimeGUIDCounter")]
        public ulong RuntimeGuidCounter { get; set; }

        #endregion Properties
    }
}
