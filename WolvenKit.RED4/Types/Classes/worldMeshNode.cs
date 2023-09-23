using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldMeshNode : worldNode
	{
		[Ordinal(4)] 
		[RED("mesh")] 
		public CResourceAsyncReference<CMesh> Mesh
		{
			get => GetPropertyValue<CResourceAsyncReference<CMesh>>();
			set => SetPropertyValue<CResourceAsyncReference<CMesh>>(value);
		}

		[Ordinal(5)] 
		[RED("meshAppearance")] 
		public CName MeshAppearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("forceAutoHideDistance")] 
		public CFloat ForceAutoHideDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("occluderType")] 
		public CEnum<visWorldOccluderType> OccluderType
		{
			get => GetPropertyValue<CEnum<visWorldOccluderType>>();
			set => SetPropertyValue<CEnum<visWorldOccluderType>>(value);
		}

		[Ordinal(8)] 
		[RED("occluderAutohideDistanceScale")] 
		public CUInt8 OccluderAutohideDistanceScale
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(9)] 
		[RED("castShadows")] 
		public CEnum<shadowsShadowCastingMode> CastShadows
		{
			get => GetPropertyValue<CEnum<shadowsShadowCastingMode>>();
			set => SetPropertyValue<CEnum<shadowsShadowCastingMode>>(value);
		}

		[Ordinal(10)] 
		[RED("castLocalShadows")] 
		public CEnum<shadowsShadowCastingMode> CastLocalShadows
		{
			get => GetPropertyValue<CEnum<shadowsShadowCastingMode>>();
			set => SetPropertyValue<CEnum<shadowsShadowCastingMode>>(value);
		}

		[Ordinal(11)] 
		[RED("castRayTracedGlobalShadows")] 
		public CEnum<shadowsShadowCastingMode> CastRayTracedGlobalShadows
		{
			get => GetPropertyValue<CEnum<shadowsShadowCastingMode>>();
			set => SetPropertyValue<CEnum<shadowsShadowCastingMode>>(value);
		}

		[Ordinal(12)] 
		[RED("castRayTracedLocalShadows")] 
		public CEnum<shadowsShadowCastingMode> CastRayTracedLocalShadows
		{
			get => GetPropertyValue<CEnum<shadowsShadowCastingMode>>();
			set => SetPropertyValue<CEnum<shadowsShadowCastingMode>>(value);
		}

		[Ordinal(13)] 
		[RED("windImpulseEnabled")] 
		public CBool WindImpulseEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("removeFromRainMap")] 
		public CBool RemoveFromRainMap
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("renderSceneLayerMask")] 
		public CBitField<RenderSceneLayerMask> RenderSceneLayerMask
		{
			get => GetPropertyValue<CBitField<RenderSceneLayerMask>>();
			set => SetPropertyValue<CBitField<RenderSceneLayerMask>>(value);
		}

		[Ordinal(16)] 
		[RED("lodLevelScales")] 
		public CUInt32 LodLevelScales
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(17)] 
		[RED("version")] 
		public CUInt8 Version
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public worldMeshNode()
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
