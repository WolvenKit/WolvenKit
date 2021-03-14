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
			get
			{
				if (_resourceVersion == null)
				{
					_resourceVersion = (CUInt32) CR2WTypeManager.Create("Uint32", "resourceVersion", cr2w, this);
				}
				return _resourceVersion;
			}
			set
			{
				if (_resourceVersion == value)
				{
					return;
				}
				_resourceVersion = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("boundingBox")] 
		public Box BoundingBox
		{
			get
			{
				if (_boundingBox == null)
				{
					_boundingBox = (Box) CR2WTypeManager.Create("Box", "boundingBox", cr2w, this);
				}
				return _boundingBox;
			}
			set
			{
				if (_boundingBox == value)
				{
					return;
				}
				_boundingBox = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("twoSided")] 
		public CBool TwoSided
		{
			get
			{
				if (_twoSided == null)
				{
					_twoSided = (CBool) CR2WTypeManager.Create("Bool", "twoSided", cr2w, this);
				}
				return _twoSided;
			}
			set
			{
				if (_twoSided == value)
				{
					return;
				}
				_twoSided = value;
				PropertySet(this);
			}
		}

		public visOccluderMeshResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
