using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;
using WolvenKit.W3SavegameEditor.Core.Savegame.Values.Engine;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values
{
    [CName("timerManager")]
    public class TimerManager
    {
        #region Properties

        [CName("isPaused")]
        public bool IsPaused { get; set; }

        [CName("time")]
        public GameTime Time { get; set; }

        [CName("timeScalePriorityIndexGenerator")]
        public uint TimeScalePriorityIndexGenerator { get; set; }

        public object Unknown1 { get; set; }

        #endregion Properties
    }
}
