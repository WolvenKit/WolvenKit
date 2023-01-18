using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save
{
    public class QuestDebugLogManager : INodeData
    {
        public string[] Lines { get; set; }
    }


    public class QuestDebugLogManagerParser : INodeParser
    {
        public static string NodeName => Constants.NodeNames.QUEST_DEBUG_LOG_MANAGER;

        public void Read(BinaryReader reader, NodeEntry node)
        {
            var data = new QuestDebugLogManager();
            var text = reader.ReadLengthPrefixedString();
            data.Lines = text.Split('\n');

            node.Value = data;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (QuestDebugLogManager)node.Value;

            var text = string.Join("\n", data.Lines);
            writer.WriteLengthPrefixedString(text);
        }
    }

}
