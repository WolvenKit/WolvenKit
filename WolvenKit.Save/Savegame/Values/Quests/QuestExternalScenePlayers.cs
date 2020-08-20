using W3SavegameEditor.Core.Savegame.Attributes;

namespace W3SavegameEditor.Core.Savegame.Values.Quests
{
    [CSerializable("questExternalScenePlayers")]
    public class QuestExternalScenePlayers
    {

        public QuestExternalScenePlayers()
        {

        }

        [CName("")]
        public QuestExternalScenePlayer QuestExternalScenePlayer1 { get; set; }


        [CName("")]
        public QuestExternalScenePlayer QuestExternalScenePlayer2 { get; set; }
    }
}