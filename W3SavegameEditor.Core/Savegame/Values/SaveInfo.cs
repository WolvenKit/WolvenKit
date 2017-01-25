using W3SavegameEditor.Core.Savegame.Attributes;

namespace W3SavegameEditor.Core.Savegame.Values
{
    [CSerializable("saveInfo")]
    public class SaveInfo
    {
        [CName("magic_number")]
        public byte[] MagicNumber { get; set; }

        [CName("description")]
        public string Description { get; set; }

        [CName("runtimeGUIDCounter")]
        public ulong RuntimeGuidCounter { get; set; }

        [CArray]
        public SaveInfoItem[] Items { get; set; }
    }
}