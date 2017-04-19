using W3SavegameEditor.Core.Savegame.Attributes;

namespace W3SavegameEditor.Core.Savegame.Values
{
    [CSerializable("CWitcherGameResource")]
    public class CWitcherGameResource
    {
        [CName("path")]
        public string Path { get; set; }
    }
}
