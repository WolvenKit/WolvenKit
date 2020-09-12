using System;
using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values.Journal
{
    public class JTrackedQuest
    {
        [CName("guid")]
        public Guid Guid { get; set; }
    }
}