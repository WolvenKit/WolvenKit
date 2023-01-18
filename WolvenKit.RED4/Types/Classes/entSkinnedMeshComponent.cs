using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entSkinnedMeshComponent : entISkinTargetComponent
	{
		[Ordinal(10)] 
		[RED("mesh")] 
		public CResourceAsyncReference<CMesh> Mesh
		{
			get => GetPropertyValue<CResourceAsyncReference<CMesh>>();
			set => SetPropertyValue<CResourceAsyncReference<CMesh>>(value);
		}

		[Ordinal(11)] 
		[RED("meshAppearance")] 
		public CName MeshAppearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("castShadows")] 
		public CBool CastShadows
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("castLocalShadows")] 
		public CBool CastLocalShadows
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("acceptDismemberment")] 
		public CBool AcceptDismemberment
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("chunkMask")] 
		public CUInt64 ChunkMask
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(16)] 
		[RED("renderingPlaneAnimationParam")] 
		public CName RenderingPlaneAnimationParam
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(17)] 
		[RED("visibilityAnimationParam")] 
		public CName VisibilityAnimationParam
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(18)] 
		[RED("order")] 
		public CUInt8 Order
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(19)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("LODMode")] 
		public CEnum<entMeshComponentLODMode> LODMode
		{
			get => GetPropertyValue<CEnum<entMeshComponentLODMode>>();
			set => SetPropertyValue<CEnum<entMeshComponentLODMode>>(value);
		}

		[Ordinal(21)] 
		[RED("useProxyMeshAsShadowMesh")] 
		public CBool UseProxyMeshAsShadowMesh
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("forcedLodDistance")] 
		public CEnum<entForcedLodDistance> ForcedLodDistance
		{
			get => GetPropertyValue<CEnum<entForcedLodDistance>>();
			set => SetPropertyValue<CEnum<entForcedLodDistance>>(value);
		}

		[Ordinal(23)] 
		[RED("overrideMeshNavigationImpact")] 
		public CBool OverrideMeshNavigationImpact
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("navigationImpact")] 
		public NavGenNavigationSetting NavigationImpact
		{
			get => GetPropertyValue<NavGenNavigationSetting>();
			set => SetPropertyValue<NavGenNavigationSetting>(value);
		}

		public entSkinnedMeshComponent()
		{
			Name = "Component";
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			RenderSceneLayerMask = Enums.RenderSceneLayerMask.Default;
			ForceLODLevel = -1;
			MeshAppearance = "default";
			CastShadows = true;
			CastLocalShadows = true;
			AcceptDismemberment = true;
			ChunkMask = 18446744073709551615;
			IsEnabled = true;
			OverrideMeshNavigationImpact = true;
			NavigationImpact = new() { NavmeshImpact = Enums.NavGenNavmeshImpact.Ignored };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
