using System;
using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values.Journal
{
    public class JObjectiveCounter
    {
        [CName("guid")]
        public Guid Guid { get; set; }

        [CName("count")]
        public int Count { get; set; }
    }
}