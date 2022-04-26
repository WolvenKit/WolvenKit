using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldEntityProxyMeshNode : worldPrefabProxyMeshNode
	{
		[Ordinal(18)] 
		[RED("ownerGlobalId")] 
		public worldGlobalNodeID OwnerGlobalId
		{
			get => GetPropertyValue<worldGlobalNodeID>();
			set => SetPropertyValue<worldGlobalNodeID>(value);
		}

		[Ordinal(19)] 
		[RED("entityAttachDistance")] 
		public CFloat EntityAttachDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldEntityProxyMeshNode()
		{
			OwnerGlobalId = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
