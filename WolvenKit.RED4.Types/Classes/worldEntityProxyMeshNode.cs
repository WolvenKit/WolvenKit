using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldEntityProxyMeshNode : worldPrefabProxyMeshNode
	{
		[Ordinal(19)] 
		[RED("ownerGlobalId")] 
		public worldGlobalNodeID OwnerGlobalId
		{
			get => GetPropertyValue<worldGlobalNodeID>();
			set => SetPropertyValue<worldGlobalNodeID>(value);
		}

		[Ordinal(20)] 
		[RED("entityAttachDistance")] 
		public CFloat EntityAttachDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldEntityProxyMeshNode()
		{
			AncestorPrefabProxyMeshNodeID = new();
			OwnerPrefabNodeId = new();
			OwnerGlobalId = new();
		}
	}
}
