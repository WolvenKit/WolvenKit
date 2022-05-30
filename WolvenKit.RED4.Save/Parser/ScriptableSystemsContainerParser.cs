using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Save.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save;

public class ScriptableSystemsContainerParser : PackageParser
{
    public static string NodeName => Constants.NodeNames.SCRIPTABLE_SYSTEMS_CONTAINER;

    public override void Read(BinaryReader reader, NodeEntry node) => Read(reader, node, RedPackageType.ScriptableSystem);
    public override void Write(NodeWriter writer, NodeEntry node) => Write(writer, node, RedPackageType.ScriptableSystem);
}
