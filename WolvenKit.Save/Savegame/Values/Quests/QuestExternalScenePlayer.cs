using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values.Quests
{
    [CSerializable("CQuestExternalScenePlayer")]
    public class QuestExternalScenePlayer
    {
        #region Constructors

        public QuestExternalScenePlayer()
        {
        }

        #endregion Constructors

        #region Properties

        [CArray("tagsCount")]
        public ExternalDialog[] ExternalDialogs { get; set; }

        [CArray("numQuests")]
        public Quest[] Quests { get; set; }

        #endregion Properties
    }
}
