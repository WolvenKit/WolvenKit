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
			get
			{
				if (_vertices == null)
				{
					_vertices = (CArray<Vector3>) CR2WTypeManager.Create("array:Vector3", "vertices", cr2w, this);
				}
				return _vertices;
			}
			set
			{
				if (_vertices == value)
				{
					return;
				}
				_vertices = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("indexBuffer")] 
		public CArray<CUInt8> IndexBuffer
		{
			get
			{
				if (_indexBuffer == null)
				{
					_indexBuffer = (CArray<CUInt8>) CR2WTypeManager.Create("array:Uint8", "indexBuffer", cr2w, this);
				}
				return _indexBuffer;
			}
			set
			{
				if (_indexBuffer == value)
				{
					return;
				}
				_indexBuffer = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("polygonVertices")] 
		public CArray<CUInt16> PolygonVertices
		{
			get
			{
				if (_polygonVertices == null)
				{
					_polygonVertices = (CArray<CUInt16>) CR2WTypeManager.Create("array:Uint16", "polygonVertices", cr2w, this);
				}
				return _polygonVertices;
			}
			set
			{
				if (_polygonVertices == value)
				{
					return;
				}
				_polygonVertices = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("compiledGeometryBuffer")] 
		public DataBuffer CompiledGeometryBuffer
		{
			get
			{
				if (_compiledGeometryBuffer == null)
				{
					_compiledGeometryBuffer = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "compiledGeometryBuffer", cr2w, this);
				}
				return _compiledGeometryBuffer;
			}
			set
			{
				if (_compiledGeometryBuffer == value)
				{
					return;
				}
				_compiledGeometryBuffer = value;
				PropertySet(this);
			}
		}

		public physicsColliderConvex(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
