using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values.Quests
{
    [CSerializable("questSystem")]
    public class QuestSystem
    {
        #region Properties

        [CName("questExternalScenePlayers")]
        public QuestExternalScenePlayers QuestExternalScenePlayers { get; set; }

        #endregion Properties
    }
}
