using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.Save
{
    public class MovingPlatformSystem : IParseableBuffer
    {
    }


    public class MovingPlatformSystemParser : INodeParser
    {
        public void Read(SaveNode node)
        {
            throw new NotImplementedException();
            //using var ms = new MemoryStream(node.DataBytes);
            //using var br = new BinaryReader(ms);
            //var data = new MovingPlatformSystem();
            //node.Data = data;
        }
    }

}
