using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save
{
    public class GameAudio : IParseableBuffer
    {
    }

    public class GameAudioParser : INodeParser
    {
        // public static string NodeName => Constants.NodeNames.GAME_AUDIO;

        public void Read(BinaryReader reader, NodeEntry node)
        {
            throw new NotImplementedException();
            //using var ms = new MemoryStream(node.DataBytes);
            //using var br = new BinaryReader(ms);
            //var data = new GameAudio();
            //node.Data = data;
        }

        public void Write(NodeWriter writer, NodeEntry node) => throw new NotImplementedException();
    }

}
