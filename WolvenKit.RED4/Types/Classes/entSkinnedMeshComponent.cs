using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entSkinnedMeshComponent : entISkinTargetComponent
	{
		[Ordinal(11)] 
		[RED("mesh")] 
		public CResourceAsyncReference<CMesh> Mesh
		{
			get => GetPropertyValue<CResourceAsyncReference<CMesh>>();
			set => SetPropertyValue<CResourceAsyncReference<CMesh>>(value);
		}

		[Ordinal(12)] 
		[RED("meshAppearance")] 
		public CName MeshAppearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("castShadows")] 
		public CEnum<shadowsShadowCastingMode> CastShadows
		{
			get => GetPropertyValue<CEnum<shadowsShadowCastingMode>>();
			set => SetPropertyValue<CEnum<shadowsShadowCastingMode>>(value);
		}

		[Ordinal(14)] 
		[RED("castLocalShadows")] 
		public CEnum<shadowsShadowCastingMode> CastLocalShadows
		{
			get => GetPropertyValue<CEnum<shadowsShadowCastingMode>>();
			set => SetPropertyValue<CEnum<shadowsShadowCastingMode>>(value);
		}

		[Ordinal(15)] 
		[RED("acceptDismemberment")] 
		public CBool AcceptDismemberment
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("chunkMask")] 
		public CUInt64 ChunkMask
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(17)] 
		[RED("renderingPlaneAnimationParam")] 
		public CName RenderingPlaneAnimationParam
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(18)] 
		[RED("visibilityAnimationParam")] 
		public CName VisibilityAnimationParam
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(19)] 
		[RED("order")] 
		public CUInt8 Order
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(20)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("LODMode")] 
		public CEnum<entMeshComponentLODMode> LODMode
		{
			get => GetPropertyValue<CEnum<entMeshComponentLODMode>>();
			set => SetPropertyValue<CEnum<entMeshComponentLODMode>>(value);
		}

		[Ordinal(22)] 
		[RED("useProxyMeshAsShadowMesh")] 
		public CBool UseProxyMeshAsShadowMesh
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("forcedLodDistance")] 
		public CEnum<entForcedLodDistance> ForcedLodDistance
		{
			get => GetPropertyValue<CEnum<entForcedLodDistance>>();
			set => SetPropertyValue<CEnum<entForcedLodDistance>>(value);
		}

		[Ordinal(24)] 
		[RED("overrideMeshNavigationImpact")] 
		public CBool OverrideMeshNavigationImpact
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("navigationImpact")] 
		public NavGenNavigationSetting NavigationImpact
		{
			get => GetPropertyValue<NavGenNavigationSetting>();
			set => SetPropertyValue<NavGenNavigationSetting>(value);
		}

		[Ordinal(26)] 
		[RED("version")] 
		public CUInt8 Version
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public entSkinnedMeshComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform();
			RenderSceneLayerMask = Enums.RenderSceneLayerMask.Default;
			ForceLODLevel = -1;
			BoundingBoxLocalBoundsOverride = -1.000000F;
			MeshAppearance = "default";
			AcceptDismemberment = true;
			ChunkMask = ulong.MaxValue;
			IsEnabled = true;
			OverrideMeshNavigationImpact = true;
			NavigationImpact = new NavGenNavigationSetting { NavmeshImpact = Enums.NavGenNavmeshImpact.Ignored };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
