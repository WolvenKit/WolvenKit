using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldInstancedMeshNode : worldNode
	{
		private CResourceAsyncReference<CMesh> _mesh;
		private CName _meshAppearance;
		private CBool _castShadows;
		private CBool _castLocalShadows;
		private CEnum<visWorldOccluderType> _occluderType;
		private CUInt32 _meshLODScales;
		private CUInt8 _occluderAutohideDistanceScale;
		private worldRenderProxyTransformBuffer _worldTransformsBuffer;

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
		[RED("castShadows")] 
		public CBool CastShadows
		{
			get => GetProperty(ref _castShadows);
			set => SetProperty(ref _castShadows, value);
		}

		[Ordinal(7)] 
		[RED("castLocalShadows")] 
		public CBool CastLocalShadows
		{
			get => GetProperty(ref _castLocalShadows);
			set => SetProperty(ref _castLocalShadows, value);
		}

		[Ordinal(8)] 
		[RED("occluderType")] 
		public CEnum<visWorldOccluderType> OccluderType
		{
			get => GetProperty(ref _occluderType);
			set => SetProperty(ref _occluderType, value);
		}

		[Ordinal(9)] 
		[RED("meshLODScales")] 
		public CUInt32 MeshLODScales
		{
			get => GetProperty(ref _meshLODScales);
			set => SetProperty(ref _meshLODScales, value);
		}

		[Ordinal(10)] 
		[RED("occluderAutohideDistanceScale")] 
		public CUInt8 OccluderAutohideDistanceScale
		{
			get => GetProperty(ref _occluderAutohideDistanceScale);
			set => SetProperty(ref _occluderAutohideDistanceScale, value);
		}

		[Ordinal(11)] 
		[RED("worldTransformsBuffer")] 
		public worldRenderProxyTransformBuffer WorldTransformsBuffer
		{
			get => GetProperty(ref _worldTransformsBuffer);
			set => SetProperty(ref _worldTransformsBuffer, value);
		}
	}
}
