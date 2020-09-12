using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values
{
    [CName("idTagManager")]
    public class IdTagManager
    {
        [CName("tagIndex")]
        public ulong TagIndex { get; set; }
    }
}