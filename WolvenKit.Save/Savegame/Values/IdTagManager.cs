using W3SavegameEditor.Core.Savegame.Attributes;

namespace W3SavegameEditor.Core.Savegame.Values
{
    [CName("idTagManager")]
    public class IdTagManager
    {
        [CName("tagIndex")]
        public ulong TagIndex { get; set; }
    }
}