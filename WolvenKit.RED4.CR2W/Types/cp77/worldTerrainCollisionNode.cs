using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTerrainCollisionNode : worldNode
	{
		private CArray<CName> _materials;
		private CArray<CUInt8> _materialIndices;
		private serializationDeferredDataBuffer _heightfieldGeometry;
		private WorldTransform _actorTransform;
		private Vector4 _extents;
		private CFloat _streamingDistance;
		private CFloat _rowScale;
		private CFloat _columnScale;
		private CFloat _heightScale;
		private CBool _increaseStreamingDistance;

		[Ordinal(4)] 
		[RED("materials")] 
		public CArray<CName> Materials
		{
			get => GetProperty(ref _materials);
			set => SetProperty(ref _materials, value);
		}

		[Ordinal(5)] 
		[RED("materialIndices")] 
		public CArray<CUInt8> MaterialIndices
		{
			get => GetProperty(ref _materialIndices);
			set => SetProperty(ref _materialIndices, value);
		}

		[Ordinal(6)] 
		[RED("heightfieldGeometry")] 
		public serializationDeferredDataBuffer HeightfieldGeometry
		{
			get => GetProperty(ref _heightfieldGeometry);
			set => SetProperty(ref _heightfieldGeometry, value);
		}

		[Ordinal(7)] 
		[RED("actorTransform")] 
		public WorldTransform ActorTransform
		{
			get => GetProperty(ref _actorTransform);
			set => SetProperty(ref _actorTransform, value);
		}

		[Ordinal(8)] 
		[RED("extents")] 
		public Vector4 Extents
		{
			get => GetProperty(ref _extents);
			set => SetProperty(ref _extents, value);
		}

		[Ordinal(9)] 
		[RED("streamingDistance")] 
		public CFloat StreamingDistance
		{
			get => GetProperty(ref _streamingDistance);
			set => SetProperty(ref _streamingDistance, value);
		}

		[Ordinal(10)] 
		[RED("rowScale")] 
		public CFloat RowScale
		{
			get => GetProperty(ref _rowScale);
			set => SetProperty(ref _rowScale, value);
		}

		[Ordinal(11)] 
		[RED("columnScale")] 
		public CFloat ColumnScale
		{
			get => GetProperty(ref _columnScale);
			set => SetProperty(ref _columnScale, value);
		}

		[Ordinal(12)] 
		[RED("heightScale")] 
		public CFloat HeightScale
		{
			get => GetProperty(ref _heightScale);
			set => SetProperty(ref _heightScale, value);
		}

		[Ordinal(13)] 
		[RED("increaseStreamingDistance")] 
		public CBool IncreaseStreamingDistance
		{
			get => GetProperty(ref _increaseStreamingDistance);
			set => SetProperty(ref _increaseStreamingDistance, value);
		}

		public worldTerrainCollisionNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
