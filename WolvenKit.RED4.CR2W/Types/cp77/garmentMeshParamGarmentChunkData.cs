using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class garmentMeshParamGarmentChunkData : CVariable
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
			get
			{
				if (_numVertices == null)
				{
					_numVertices = (CUInt32) CR2WTypeManager.Create("Uint32", "numVertices", cr2w, this);
				}
				return _numVertices;
			}
			set
			{
				if (_numVertices == value)
				{
					return;
				}
				_numVertices = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("lodMask")] 
		public CUInt8 LodMask
		{
			get
			{
				if (_lodMask == null)
				{
					_lodMask = (CUInt8) CR2WTypeManager.Create("Uint8", "lodMask", cr2w, this);
				}
				return _lodMask;
			}
			set
			{
				if (_lodMask == value)
				{
					return;
				}
				_lodMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isTwoSided")] 
		public CBool IsTwoSided
		{
			get
			{
				if (_isTwoSided == null)
				{
					_isTwoSided = (CBool) CR2WTypeManager.Create("Bool", "isTwoSided", cr2w, this);
				}
				return _isTwoSided;
			}
			set
			{
				if (_isTwoSided == value)
				{
					return;
				}
				_isTwoSided = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("vertices")] 
		public DataBuffer Vertices
		{
			get
			{
				if (_vertices == null)
				{
					_vertices = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "vertices", cr2w, this);
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

		[Ordinal(4)] 
		[RED("indices")] 
		public DataBuffer Indices
		{
			get
			{
				if (_indices == null)
				{
					_indices = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "indices", cr2w, this);
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

		[Ordinal(5)] 
		[RED("morphOffsets")] 
		public DataBuffer MorphOffsets
		{
			get
			{
				if (_morphOffsets == null)
				{
					_morphOffsets = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "morphOffsets", cr2w, this);
				}
				return _morphOffsets;
			}
			set
			{
				if (_morphOffsets == value)
				{
					return;
				}
				_morphOffsets = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("garmentFlags")] 
		public DataBuffer GarmentFlags
		{
			get
			{
				if (_garmentFlags == null)
				{
					_garmentFlags = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "garmentFlags", cr2w, this);
				}
				return _garmentFlags;
			}
			set
			{
				if (_garmentFlags == value)
				{
					return;
				}
				_garmentFlags = value;
				PropertySet(this);
			}
		}

		public garmentMeshParamGarmentChunkData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
