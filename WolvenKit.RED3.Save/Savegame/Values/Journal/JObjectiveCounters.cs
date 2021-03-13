using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values.Journal
{
    public class JObjectiveCounters
    {
        #region Properties

        public JObjectiveCounter[] Counters { get; set; }

        [CName("Size")]
        public uint Size { get; set; }

        #endregion Properties
    }
}
