using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class garmentMeshParamGarmentChunkData : RedBaseClass
	{
		private CUInt32 _numVertices;
		private CUInt8 _lodMask;
		private CBool _isTwoSided;
		private DataBuffer _vertices;
		private DataBuffer _indices;
		private DataBuffer _morphOffsets;
		private DataBuffer _garmentFlags;

		[Ordinal(0)] 
		[RED("numVertices")] 
		public CUInt32 NumVertices
		{
			get => GetProperty(ref _numVertices);
			set => SetProperty(ref _numVertices, value);
		}

		[Ordinal(1)] 
		[RED("lodMask")] 
		public CUInt8 LodMask
		{
			get => GetProperty(ref _lodMask);
			set => SetProperty(ref _lodMask, value);
		}

		[Ordinal(2)] 
		[RED("isTwoSided")] 
		public CBool IsTwoSided
		{
			get => GetProperty(ref _isTwoSided);
			set => SetProperty(ref _isTwoSided, value);
		}

		[Ordinal(3)] 
		[RED("vertices")] 
		public DataBuffer Vertices
		{
			get => GetProperty(ref _vertices);
			set => SetProperty(ref _vertices, value);
		}

		[Ordinal(4)] 
		[RED("indices")] 
		public DataBuffer Indices
		{
			get => GetProperty(ref _indices);
			set => SetProperty(ref _indices, value);
		}

		[Ordinal(5)] 
		[RED("morphOffsets")] 
		public DataBuffer MorphOffsets
		{
			get => GetProperty(ref _morphOffsets);
			set => SetProperty(ref _morphOffsets, value);
		}

		[Ordinal(6)] 
		[RED("garmentFlags")] 
		public DataBuffer GarmentFlags
		{
			get => GetProperty(ref _garmentFlags);
			set => SetProperty(ref _garmentFlags, value);
		}
	}
}
