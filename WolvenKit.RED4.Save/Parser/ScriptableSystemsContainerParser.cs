using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save;

public class ScriptableSystemsContainerParser : INodeParser
{
    public void Read(SaveNode node)
    {
        File.WriteAllBytes(@"C:\Dev\C77\lol.bin", node.DataBytes);

        using var ms = new MemoryStream(node.DataBytes[4..]);
        using var br = new BinaryReader(ms);

        var dummyBuffer = new RedBuffer();

        var reader = new PackageReader(br);
        reader.ReadBuffer(dummyBuffer, typeof(gamePersistentStateDataResource));

        node.Data = dummyBuffer.Data;
    }
}
