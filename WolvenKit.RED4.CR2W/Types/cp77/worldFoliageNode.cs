using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldFoliageNode : worldNode
	{
		private raRef<CMesh> _mesh;
		private CName _meshAppearance;
		private raRef<worldFoliageCompiledResource> _foliageResource;
		private Box _foliageLocalBounds;
		private CFloat _autoHideDistanceScale;
		private CFloat _lodDistanceScale;
		private CFloat _streamingDistance;
		private worldFoliagePopulationSpanInfo _populationSpanInfo;
		private CUInt64 _destructionHash;
		private CFloat _meshHeight;

		[Ordinal(4)] 
		[RED("mesh")] 
		public raRef<CMesh> Mesh
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
		[RED("foliageResource")] 
		public raRef<worldFoliageCompiledResource> FoliageResource
		{
			get => GetProperty(ref _foliageResource);
			set => SetProperty(ref _foliageResource, value);
		}

		[Ordinal(7)] 
		[RED("foliageLocalBounds")] 
		public Box FoliageLocalBounds
		{
			get => GetProperty(ref _foliageLocalBounds);
			set => SetProperty(ref _foliageLocalBounds, value);
		}

		[Ordinal(8)] 
		[RED("autoHideDistanceScale")] 
		public CFloat AutoHideDistanceScale
		{
			get => GetProperty(ref _autoHideDistanceScale);
			set => SetProperty(ref _autoHideDistanceScale, value);
		}

		[Ordinal(9)] 
		[RED("lodDistanceScale")] 
		public CFloat LodDistanceScale
		{
			get => GetProperty(ref _lodDistanceScale);
			set => SetProperty(ref _lodDistanceScale, value);
		}

		[Ordinal(10)] 
		[RED("streamingDistance")] 
		public CFloat StreamingDistance
		{
			get => GetProperty(ref _streamingDistance);
			set => SetProperty(ref _streamingDistance, value);
		}

		[Ordinal(11)] 
		[RED("populationSpanInfo")] 
		public worldFoliagePopulationSpanInfo PopulationSpanInfo
		{
			get => GetProperty(ref _populationSpanInfo);
			set => SetProperty(ref _populationSpanInfo, value);
		}

		[Ordinal(12)] 
		[RED("destructionHash")] 
		public CUInt64 DestructionHash
		{
			get => GetProperty(ref _destructionHash);
			set => SetProperty(ref _destructionHash, value);
		}

		[Ordinal(13)] 
		[RED("meshHeight")] 
		public CFloat MeshHeight
		{
			get => GetProperty(ref _meshHeight);
			set => SetProperty(ref _meshHeight, value);
		}

		public worldFoliageNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
