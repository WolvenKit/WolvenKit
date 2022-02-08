using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldDestructibleProxyMeshNode : worldPrefabProxyMeshNode
	{
		[Ordinal(19)] 
		[RED("ownerHash")] 
		public CUInt64 OwnerHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public worldDestructibleProxyMeshNode()
		{
			AncestorPrefabProxyMeshNodeID = new();
			OwnerPrefabNodeId = new();
		}
	}
}
