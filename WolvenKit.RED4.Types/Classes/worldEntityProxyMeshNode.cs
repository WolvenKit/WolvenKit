using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldEntityProxyMeshNode : worldPrefabProxyMeshNode
	{
		private worldGlobalNodeID _ownerGlobalId;
		private CFloat _entityAttachDistance;

		[Ordinal(19)] 
		[RED("ownerGlobalId")] 
		public worldGlobalNodeID OwnerGlobalId
		{
			get => GetProperty(ref _ownerGlobalId);
			set => SetProperty(ref _ownerGlobalId, value);
		}

		[Ordinal(20)] 
		[RED("entityAttachDistance")] 
		public CFloat EntityAttachDistance
		{
			get => GetProperty(ref _entityAttachDistance);
			set => SetProperty(ref _entityAttachDistance, value);
		}
	}
}
