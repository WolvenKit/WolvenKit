
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldBuildingProxyMeshNode : worldPrefabProxyMeshNode
	{

		public worldBuildingProxyMeshNode()
		{
			AncestorPrefabProxyMeshNodeID = new();
			OwnerPrefabNodeId = new();
		}
	}
}
