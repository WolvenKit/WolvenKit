using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values
{
    [CSerializable("CWitcherGameResource")]
    public class CWitcherGameResource
    {
        [CName("path")]
        public string Path { get; set; }
    }
}
