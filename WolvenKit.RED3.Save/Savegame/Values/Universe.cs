using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;
using WolvenKit.W3SavegameEditor.Core.Savegame.Values.Engine;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values
{
    public class Player
    {
        #region Properties

        [CName("id")]
        public IdTag Id { get; set; }

        [CName("position")]
        //[CType("Vector")]
        public object Position { get; set; }

        [CName("Rotation")]
        public EulerAngles Rotation { get; set; }

        [CName("template")]
        public string Template { get; set; }

        #endregion Properties
    }

    public class Universe
    {
        #region Properties

        [CName("Player")]
        public Player Player { get; set; }

        #endregion Properties

    }
}
