using System;
using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values.Journal
{
    public class JHighlightedObjective
    {
        [CName("guid")]
        public Guid Guid { get; set; }
    }
}