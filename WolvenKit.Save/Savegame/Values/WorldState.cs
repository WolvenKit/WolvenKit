using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values
{
    [CName("worldState")]
    public class WorldState
    {
        [CName("entityStateChangeRequests")]
        public EntityStateChangeRequests EntityStateChangeRequests { get; set; }
    }
}