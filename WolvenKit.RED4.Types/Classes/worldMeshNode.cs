using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldMeshNode : worldNode
	{
		private CResourceAsyncReference<CMesh> _mesh;
		private CName _meshAppearance;
		private CFloat _forceAutoHideDistance;
		private CEnum<visWorldOccluderType> _occluderType;
		private CUInt8 _occluderAutohideDistanceScale;
		private CBool _castShadows;
		private CBool _castLocalShadows;
		private CBool _windImpulseEnabled;
		private CBool _removeFromRainMap;
		private CEnum<RenderSceneLayerMask> _renderSceneLayerMask;
		private CUInt32 _lodLevelScales;

		[Ordinal(4)] 
		[RED("mesh")] 
		public CResourceAsyncReference<CMesh> Mesh
		{
			get => GetProperty(ref _mesh);
			set => SetProperty(ref _mesh, value);
		}

		[Ordinal(5)] 
		[RED("meshAppearance")] 
		public CName MeshAppearance
		{
			get => GetProperty(ref _meshAppearance);
			set => SetProperty(ref _meshAppearance, value);
		}

		[Ordinal(6)] 
		[RED("forceAutoHideDistance")] 
		public CFloat ForceAutoHideDistance
		{
			get => GetProperty(ref _forceAutoHideDistance);
			set => SetProperty(ref _forceAutoHideDistance, value);
		}

		[Ordinal(7)] 
		[RED("occluderType")] 
		public CEnum<visWorldOccluderType> OccluderType
		{
			get => GetProperty(ref _occluderType);
			set => SetProperty(ref _occluderType, value);
		}

		[Ordinal(8)] 
		[RED("occluderAutohideDistanceScale")] 
		public CUInt8 OccluderAutohideDistanceScale
		{
			get => GetProperty(ref _occluderAutohideDistanceScale);
			set => SetProperty(ref _occluderAutohideDistanceScale, value);
		}

		[Ordinal(9)] 
		[RED("castShadows")] 
		public CBool CastShadows
		{
			get => GetProperty(ref _castShadows);
			set => SetProperty(ref _castShadows, value);
		}

		[Ordinal(10)] 
		[RED("castLocalShadows")] 
		public CBool CastLocalShadows
		{
			get => GetProperty(ref _castLocalShadows);
			set => SetProperty(ref _castLocalShadows, value);
		}

		[Ordinal(11)] 
		[RED("windImpulseEnabled")] 
		public CBool WindImpulseEnabled
		{
			get => GetProperty(ref _windImpulseEnabled);
			set => SetProperty(ref _windImpulseEnabled, value);
		}

		[Ordinal(12)] 
		[RED("removeFromRainMap")] 
		public CBool RemoveFromRainMap
		{
			get => GetProperty(ref _removeFromRainMap);
			set => SetProperty(ref _removeFromRainMap, value);
		}

		[Ordinal(13)] 
		[RED("renderSceneLayerMask")] 
		public CEnum<RenderSceneLayerMask> RenderSceneLayerMask
		{
			get => GetProperty(ref _renderSceneLayerMask);
			set => SetProperty(ref _renderSceneLayerMask, value);
		}

		[Ordinal(14)] 
		[RED("lodLevelScales")] 
		public CUInt32 LodLevelScales
		{
			get => GetProperty(ref _lodLevelScales);
			set => SetProperty(ref _lodLevelScales, value);
		}
	}
}
