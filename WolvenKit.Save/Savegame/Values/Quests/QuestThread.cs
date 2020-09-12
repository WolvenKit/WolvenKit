using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values.Quests
{
    [CSerializable("questThread")]
    public class QuestThread
    {
        public QuestThread()
        {
            
        }

        [CArray("numBlocksToActivate")]
        public QuestBlock[] QuestBlocksToActivate { get; set; }

        [CArray("numBlocks")]
        public QuestBlock[] QuestBlocks { get; set; }

        [CArray("numThreads", ElementName = "questThread")]
        public QuestThreadKeyValue[] QuestThreads { get; set; }
    }
}