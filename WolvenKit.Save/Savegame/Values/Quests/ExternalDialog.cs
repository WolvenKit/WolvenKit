using System;
using W3SavegameEditor.Core.Savegame.Attributes;

namespace W3SavegameEditor.Core.Savegame.Values.Quests
{
    [CSerializable("ExternalDialog")]
    public class ExternalDialog
    {
        [CName("tag")]
        public string Tag { get; set; }
        [CArray("dialogsCount")]
        public Guid[] Dialogs { get; set; }
    }
}