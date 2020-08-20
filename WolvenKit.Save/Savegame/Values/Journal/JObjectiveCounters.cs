using W3SavegameEditor.Core.Savegame.Attributes;

namespace W3SavegameEditor.Core.Savegame.Values.Journal
{
    public class JObjectiveCounters
    {
        [CName("Size")]
        public uint Size { get; set; }

        public JObjectiveCounter[] Counters { get; set; }
    }
}