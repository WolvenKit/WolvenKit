using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entMeshComponent : entIVisualComponent
	{
		[Ordinal(8)] 
		[RED("mesh")] 
		public CResourceAsyncReference<CMesh> Mesh
		{
			get => GetPropertyValue<CResourceAsyncReference<CMesh>>();
			set => SetPropertyValue<CResourceAsyncReference<CMesh>>(value);
		}

		[Ordinal(9)] 
		[RED("meshAppearance")] 
		public CName MeshAppearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("castShadows")] 
		public CBool CastShadows
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("castLocalShadows")] 
		public CBool CastLocalShadows
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("motionBlurScale")] 
		public CFloat MotionBlurScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("visualScale")] 
		public Vector3 VisualScale
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(14)] 
		[RED("renderingPlane")] 
		public CEnum<ERenderingPlane> RenderingPlane
		{
			get => GetPropertyValue<CEnum<ERenderingPlane>>();
			set => SetPropertyValue<CEnum<ERenderingPlane>>(value);
		}

		[Ordinal(15)] 
		[RED("objectTypeID")] 
		public CEnum<ERenderObjectType> ObjectTypeID
		{
			get => GetPropertyValue<CEnum<ERenderObjectType>>();
			set => SetPropertyValue<CEnum<ERenderObjectType>>(value);
		}

		[Ordinal(16)] 
		[RED("numInstances")] 
		public CUInt32 NumInstances
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(17)] 
		[RED("chunkMask")] 
		public CUInt64 ChunkMask
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
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
		[RED("forcedLodDistance")] 
		public CEnum<entForcedLodDistance> ForcedLodDistance
		{
			get => GetPropertyValue<CEnum<entForcedLodDistance>>();
			set => SetPropertyValue<CEnum<entForcedLodDistance>>(value);
		}

		[Ordinal(22)] 
		[RED("overrideMeshNavigationImpact")] 
		public CBool OverrideMeshNavigationImpact
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("navigationImpact")] 
		public NavGenNavigationSetting NavigationImpact
		{
			get => GetPropertyValue<NavGenNavigationSetting>();
			set => SetPropertyValue<NavGenNavigationSetting>(value);
		}

		public entMeshComponent()
		{
			Name = "Component";
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			RenderSceneLayerMask = Enums.RenderSceneLayerMask.Default;
			ForceLODLevel = -1;
			MeshAppearance = "default";
			CastShadows = true;
			CastLocalShadows = true;
			MotionBlurScale = 1.000000F;
			VisualScale = new() { X = 1.000000F, Y = 1.000000F, Z = 1.000000F };
			ChunkMask = 18446744073709551615;
			IsEnabled = true;
			OverrideMeshNavigationImpact = true;
			NavigationImpact = new() { NavmeshImpact = Enums.NavGenNavmeshImpact.Ignored };
		}
	}
}
