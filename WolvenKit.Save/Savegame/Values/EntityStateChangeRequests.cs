using W3SavegameEditor.Core.Savegame.Attributes;

namespace W3SavegameEditor.Core.Savegame.Values
{
    public class EntityStateChangeRequests
    {
        [CName("requestsCount")]
        public uint RequestsCount { get; set; }
    }
}