using W3SavegameEditor.Core.Savegame.Attributes;
using W3SavegameEditor.Core.Savegame.Values.Engine;

namespace W3SavegameEditor.Core.Savegame.Values
{
    [CName("timerManager")]
    public class TimerManager
    {
        [CName("time")]
        public GameTime Time { get; set; }

        public object Unknown1 { get; set; }

        [CName("isPaused")]
        public bool IsPaused { get; set; }

        [CName("timeScalePriorityIndexGenerator")]
        public uint TimeScalePriorityIndexGenerator { get; set; }
         
    }
}