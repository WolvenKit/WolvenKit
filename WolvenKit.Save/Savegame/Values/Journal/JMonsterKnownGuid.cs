using System;
using W3SavegameEditor.Core.Savegame.Attributes;

namespace W3SavegameEditor.Core.Savegame.Values.Journal
{
    public class JMonsterKnownGuid
    {
        [CName("guid")]
        public Guid Guid { get; set; }
    }
}