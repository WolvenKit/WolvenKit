using System;
using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values.Quests
{
    [CSerializable("ExternalDialog")]
    public class ExternalDialog
    {
        #region Properties

        [CArray("dialogsCount")]
        public Guid[] Dialogs { get; set; }

        [CName("tag")]
        public string Tag { get; set; }

        #endregion Properties
    }
}
