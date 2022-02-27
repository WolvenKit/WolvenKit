using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.Save
{
    public class ClassName : IParseableBuffer
    {
    }


    public class ClassNameParser : INodeParser
    {
        // public static string NodeName => "";

        public void Read(SaveNode node)
        {
            using var ms = new MemoryStream(node.DataBytes);
            using var br = new BinaryReader(ms);
            var data = new ClassName();
            node.Data = data;
        }

        public SaveNode Write() => throw new NotImplementedException();
    }

}
