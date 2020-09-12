using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values
{
    public class EntityStateChangeRequests
    {
        [CName("requestsCount")]
        public uint RequestsCount { get; set; }
    }
}