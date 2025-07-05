using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldEntityProxyMeshNode : worldPrefabProxyMeshNode
	{
		[Ordinal(20)] 
		[RED("ownerGlobalId")] 
		public worldGlobalNodeID OwnerGlobalId
		{
			get => GetPropertyValue<worldGlobalNodeID>();
			set => SetPropertyValue<worldGlobalNodeID>(value);
		}

		[Ordinal(21)] 
		[RED("entityAttachDistance")] 
		public CFloat EntityAttachDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldEntityProxyMeshNode()
		{
			OwnerGlobalId = new worldGlobalNodeID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
