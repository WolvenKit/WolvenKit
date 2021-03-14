using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamUICollisionData : meshMeshParameter
	{
		private CArray<Vector2> _uvs;
		private CArray<CUInt16> _trianglesIndices;
		private CArray<Vector3> _vertices;

		[Ordinal(0)] 
		[RED("uvs")] 
		public CArray<Vector2> Uvs
		{
			get
			{
				if (_uvs == null)
				{
					_uvs = (CArray<Vector2>) CR2WTypeManager.Create("array:Vector2", "uvs", cr2w, this);
				}
				return _uvs;
			}
			set
			{
				if (_uvs == value)
				{
					return;
				}
				_uvs = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("trianglesIndices")] 
		public CArray<CUInt16> TrianglesIndices
		{
			get
			{
				if (_trianglesIndices == null)
				{
					_trianglesIndices = (CArray<CUInt16>) CR2WTypeManager.Create("array:Uint16", "trianglesIndices", cr2w, this);
				}
				return _trianglesIndices;
			}
			set
			{
				if (_trianglesIndices == value)
				{
					return;
				}
				_trianglesIndices = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		public meshMeshParamUICollisionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
