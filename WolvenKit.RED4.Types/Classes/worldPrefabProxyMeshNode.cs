using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldPrefabProxyMeshNode : worldMeshNode
	{
		[Ordinal(15)] 
		[RED("nearAutoHideDistance")] 
		public CFloat NearAutoHideDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("ancestorPrefabProxyMeshNodeID")] 
		public worldGlobalNodeID AncestorPrefabProxyMeshNodeID
		{
			get => GetPropertyValue<worldGlobalNodeID>();
			set => SetPropertyValue<worldGlobalNodeID>(value);
		}

		[Ordinal(17)] 
		[RED("ownerPrefabNodeId")] 
		public worldGlobalNodeID OwnerPrefabNodeId
		{
			get => GetPropertyValue<worldGlobalNodeID>();
			set => SetPropertyValue<worldGlobalNodeID>(value);
		}

		[Ordinal(18)] 
		[RED("nbNodesUnderProxy")] 
		public CUInt32 NbNodesUnderProxy
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public worldPrefabProxyMeshNode()
		{
			MeshAppearance = "default";
			OccluderAutohideDistanceScale = 255;
			CastShadows = true;
			CastLocalShadows = true;
			WindImpulseEnabled = true;
			RenderSceneLayerMask = Enums.RenderSceneLayerMask.Default;
			LodLevelScales = 4294967295;
		}
	}
}
