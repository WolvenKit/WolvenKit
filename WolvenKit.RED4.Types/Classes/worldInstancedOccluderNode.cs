using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldInstancedOccluderNode : worldNode
	{
		private Box _worldBounds;
		private CEnum<visWorldOccluderType> _occluderType;
		private CUInt8 _autohideDistanceScale;
		private CResourceAsyncReference<CMesh> _mesh;

		[Ordinal(4)] 
		[RED("worldBounds")] 
		public Box WorldBounds
		{
			get => GetProperty(ref _worldBounds);
			set => SetProperty(ref _worldBounds, value);
		}

		[Ordinal(5)] 
		[RED("occluderType")] 
		public CEnum<visWorldOccluderType> OccluderType
		{
			get => GetProperty(ref _occluderType);
			set => SetProperty(ref _occluderType, value);
		}

		[Ordinal(6)] 
		[RED("autohideDistanceScale")] 
		public CUInt8 AutohideDistanceScale
		{
			get => GetProperty(ref _autohideDistanceScale);
			set => SetProperty(ref _autohideDistanceScale, value);
		}

		[Ordinal(7)] 
		[RED("mesh")] 
		public CResourceAsyncReference<CMesh> Mesh
		{
			get => GetProperty(ref _mesh);
			set => SetProperty(ref _mesh, value);
		}

		public worldInstancedOccluderNode()
		{
			_autohideDistanceScale = 255;
		}
	}
}
