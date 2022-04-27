using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save
{
    public class GameAudio : INodeData
    {
    }

    public class GameAudioParser : INodeParser
    {
        public static string NodeName => Constants.NodeNames.GAME_AUDIO;

        public void Read(BinaryReader reader, NodeEntry node)
        {
            ParserHelper.ReadChildren(reader, node);
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            foreach (var child in node.Children)
            {
                writer.Write(child);
            }
        }
    }

}
