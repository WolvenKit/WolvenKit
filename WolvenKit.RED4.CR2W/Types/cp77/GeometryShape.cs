using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GeometryShape : ISerializable
	{
		private CArray<Vector3> _vertices;
		private CArray<CUInt16> _indices;
		private CArray<GeometryShapeFace> _faces;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("indices")] 
		public CArray<CUInt16> Indices
		{
			get
			{
				if (_indices == null)
				{
					_indices = (CArray<CUInt16>) CR2WTypeManager.Create("array:Uint16", "indices", cr2w, this);
				}
				return _indices;
			}
			set
			{
				if (_indices == value)
				{
					return;
				}
				_indices = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("faces")] 
		public CArray<GeometryShapeFace> Faces
		{
			get
			{
				if (_faces == null)
				{
					_faces = (CArray<GeometryShapeFace>) CR2WTypeManager.Create("array:GeometryShapeFace", "faces", cr2w, this);
				}
				return _faces;
			}
			set
			{
				if (_faces == value)
				{
					return;
				}
				_faces = value;
				PropertySet(this);
			}
		}

		public GeometryShape(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
