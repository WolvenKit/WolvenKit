using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class visOccluderMeshResource : visIOccluderResource
	{
		private CUInt32 _resourceVersion;
		private DataBuffer _vertices;
		private DataBuffer _indices;
		private Box _boundingBox;
		private CBool _twoSided;

		[Ordinal(1)] 
		[RED("resourceVersion")] 
		public CUInt32 ResourceVersion
		{
			get => GetProperty(ref _resourceVersion);
			set => SetProperty(ref _resourceVersion, value);
		}

		[Ordinal(2)] 
		[RED("vertices")] 
		public DataBuffer Vertices
		{
			get => GetProperty(ref _vertices);
			set => SetProperty(ref _vertices, value);
		}

		[Ordinal(3)] 
		[RED("indices")] 
		public DataBuffer Indices
		{
			get => GetProperty(ref _indices);
			set => SetProperty(ref _indices, value);
		}

		[Ordinal(4)] 
		[RED("boundingBox")] 
		public Box BoundingBox
		{
			get => GetProperty(ref _boundingBox);
			set => SetProperty(ref _boundingBox, value);
		}

		[Ordinal(5)] 
		[RED("twoSided")] 
		public CBool TwoSided
		{
			get => GetProperty(ref _twoSided);
			set => SetProperty(ref _twoSided, value);
		}

		public visOccluderMeshResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
