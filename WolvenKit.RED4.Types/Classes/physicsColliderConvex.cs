using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsColliderConvex : physicsICollider
	{
		private CArray<Vector3> _vertices;
		private CArray<CUInt8> _indexBuffer;
		private CArray<CUInt16> _polygonVertices;
		private DataBuffer _compiledGeometryBuffer;

		[Ordinal(8)] 
		[RED("vertices")] 
		public CArray<Vector3> Vertices
		{
			get => GetProperty(ref _vertices);
			set => SetProperty(ref _vertices, value);
		}

		[Ordinal(9)] 
		[RED("indexBuffer")] 
		public CArray<CUInt8> IndexBuffer
		{
			get => GetProperty(ref _indexBuffer);
			set => SetProperty(ref _indexBuffer, value);
		}

		[Ordinal(10)] 
		[RED("polygonVertices")] 
		public CArray<CUInt16> PolygonVertices
		{
			get => GetProperty(ref _polygonVertices);
			set => SetProperty(ref _polygonVertices, value);
		}

		[Ordinal(11)] 
		[RED("compiledGeometryBuffer")] 
		public DataBuffer CompiledGeometryBuffer
		{
			get => GetProperty(ref _compiledGeometryBuffer);
			set => SetProperty(ref _compiledGeometryBuffer, value);
		}
	}
}
