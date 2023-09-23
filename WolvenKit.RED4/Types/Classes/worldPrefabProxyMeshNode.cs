using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class worldPrefabProxyMeshNode : worldMeshNode
	{
		[Ordinal(18)] 
		[RED("nearAutoHideDistance")] 
		public CFloat NearAutoHideDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("nbNodesUnderProxy")] 
		public CUInt32 NbNodesUnderProxy
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public worldPrefabProxyMeshNode()
		{
			Mesh = new CResourceAsyncReference<CMesh>(11172089723266472358);
			MeshAppearance = "default";
			OccluderAutohideDistanceScale = 255;
			WindImpulseEnabled = true;
			RenderSceneLayerMask = Enums.RenderSceneLayerMask.Default;
			LodLevelScales = uint.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
