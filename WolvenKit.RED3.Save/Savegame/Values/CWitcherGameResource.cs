using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values
{
    [CSerializable("CWitcherGameResource")]
    public class CWitcherGameResource
    {
        #region Properties

        [CName("path")]
        public string Path { get; set; }

        #endregion Properties
    }
}
