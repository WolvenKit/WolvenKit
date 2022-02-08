
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldDecorationProxyMeshNode : worldPrefabProxyMeshNode
	{

		public worldDecorationProxyMeshNode()
		{
			AncestorPrefabProxyMeshNodeID = new();
			OwnerPrefabNodeId = new();
		}
	}
}
