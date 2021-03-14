using System;
using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values
{
    [CName("worldInfo")]
    public class WorldInfo
    {
        #region Properties

        [CName("world")]
        public String World { get; set; }

        #endregion Properties
    }
}
