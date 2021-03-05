using System;
using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values.Journal
{
    public class JObjectiveCounter
    {
        #region Properties

        [CName("count")]
        public int Count { get; set; }

        [CName("guid")]
        public Guid Guid { get; set; }

        #endregion Properties
    }
}
