using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsColliderConvex : physicsICollider
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

		public physicsColliderConvex(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
