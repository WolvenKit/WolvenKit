using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SMeshChunkPacked : CVariable
	{
		private CEnum<EMeshVertexType> _vertexType;
		private CArray<CName> _materialID;
		private CUInt8 _numBonesPerVertex;
		private CUInt32 _numVertices;
		private CUInt32 _numIndices;
		private CUInt32 _firstVertex;
		private CUInt32 _firstIndex;
		private CEnum<EMeshChunkRenderMask> _renderMask;
		private CEnum<EMeshChunkFlags> _chunkRenderMask;
		private CBool _useForShadowmesh;
		private CArray<SMeshStream> _streams;
		private CUInt64 _streamMask;
		private CUInt8 _lodMask;

		[Ordinal(0)] 
		[RED("vertexType")] 
		public CEnum<EMeshVertexType> VertexType
		{
			get
			{
				if (_vertexType == null)
				{
					_vertexType = (CEnum<EMeshVertexType>) CR2WTypeManager.Create("EMeshVertexType", "vertexType", cr2w, this);
				}
				return _vertexType;
			}
			set
			{
				if (_vertexType == value)
				{
					return;
				}
				_vertexType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("materialID")] 
		public CArray<CName> MaterialID
		{
			get
			{
				if (_materialID == null)
				{
					_materialID = (CArray<CName>) CR2WTypeManager.Create("array:CName", "materialID", cr2w, this);
				}
				return _materialID;
			}
			set
			{
				if (_materialID == value)
				{
					return;
				}
				_materialID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("numBonesPerVertex")] 
		public CUInt8 NumBonesPerVertex
		{
			get
			{
				if (_numBonesPerVertex == null)
				{
					_numBonesPerVertex = (CUInt8) CR2WTypeManager.Create("Uint8", "numBonesPerVertex", cr2w, this);
				}
				return _numBonesPerVertex;
			}
			set
			{
				if (_numBonesPerVertex == value)
				{
					return;
				}
				_numBonesPerVertex = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("numIndices")] 
		public CUInt32 NumIndices
		{
			get
			{
				if (_numIndices == null)
				{
					_numIndices = (CUInt32) CR2WTypeManager.Create("Uint32", "numIndices", cr2w, this);
				}
				return _numIndices;
			}
			set
			{
				if (_numIndices == value)
				{
					return;
				}
				_numIndices = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("firstVertex")] 
		public CUInt32 FirstVertex
		{
			get
			{
				if (_firstVertex == null)
				{
					_firstVertex = (CUInt32) CR2WTypeManager.Create("Uint32", "firstVertex", cr2w, this);
				}
				return _firstVertex;
			}
			set
			{
				if (_firstVertex == value)
				{
					return;
				}
				_firstVertex = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("firstIndex")] 
		public CUInt32 FirstIndex
		{
			get
			{
				if (_firstIndex == null)
				{
					_firstIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "firstIndex", cr2w, this);
				}
				return _firstIndex;
			}
			set
			{
				if (_firstIndex == value)
				{
					return;
				}
				_firstIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("renderMask")] 
		public CEnum<EMeshChunkRenderMask> RenderMask
		{
			get
			{
				if (_renderMask == null)
				{
					_renderMask = (CEnum<EMeshChunkRenderMask>) CR2WTypeManager.Create("EMeshChunkRenderMask", "renderMask", cr2w, this);
				}
				return _renderMask;
			}
			set
			{
				if (_renderMask == value)
				{
					return;
				}
				_renderMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("chunkRenderMask")] 
		public CEnum<EMeshChunkFlags> ChunkRenderMask
		{
			get
			{
				if (_chunkRenderMask == null)
				{
					_chunkRenderMask = (CEnum<EMeshChunkFlags>) CR2WTypeManager.Create("EMeshChunkFlags", "chunkRenderMask", cr2w, this);
				}
				return _chunkRenderMask;
			}
			set
			{
				if (_chunkRenderMask == value)
				{
					return;
				}
				_chunkRenderMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("useForShadowmesh")] 
		public CBool UseForShadowmesh
		{
			get
			{
				if (_useForShadowmesh == null)
				{
					_useForShadowmesh = (CBool) CR2WTypeManager.Create("Bool", "useForShadowmesh", cr2w, this);
				}
				return _useForShadowmesh;
			}
			set
			{
				if (_useForShadowmesh == value)
				{
					return;
				}
				_useForShadowmesh = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("streams")] 
		public CArray<SMeshStream> Streams
		{
			get
			{
				if (_streams == null)
				{
					_streams = (CArray<SMeshStream>) CR2WTypeManager.Create("array:SMeshStream", "streams", cr2w, this);
				}
				return _streams;
			}
			set
			{
				if (_streams == value)
				{
					return;
				}
				_streams = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("streamMask")] 
		public CUInt64 StreamMask
		{
			get
			{
				if (_streamMask == null)
				{
					_streamMask = (CUInt64) CR2WTypeManager.Create("Uint64", "streamMask", cr2w, this);
				}
				return _streamMask;
			}
			set
			{
				if (_streamMask == value)
				{
					return;
				}
				_streamMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
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

		public SMeshChunkPacked(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
