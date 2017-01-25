using System;
using W3SavegameEditor.Core.Savegame.Attributes;

namespace W3SavegameEditor.Core.Savegame.Values.Journal
{
    public class JTrackedQuest
    {
        [CName("guid")]
        public Guid Guid { get; set; }
    }
}