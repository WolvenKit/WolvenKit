using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendChunk : CVariable
	{
		private rendVertexBufferChunk _chunkVertices;
		private rendIndexBufferChunk _chunkIndices;
		private CUInt16 _numVertices;
		private CUInt32 _numIndices;
		private CArray<CName> _materialId;
		private CUInt8 _vertexFactory;
		private CUInt16 _baseRenderMask;
		private CUInt16 _mergedRenderMask;
		private CEnum<EMeshChunkFlags> _renderMask;
		private CUInt8 _lodMask;

		[Ordinal(0)] 
		[RED("chunkVertices")] 
		public rendVertexBufferChunk ChunkVertices
		{
			get
			{
				if (_chunkVertices == null)
				{
					_chunkVertices = (rendVertexBufferChunk) CR2WTypeManager.Create("rendVertexBufferChunk", "chunkVertices", cr2w, this);
				}
				return _chunkVertices;
			}
			set
			{
				if (_chunkVertices == value)
				{
					return;
				}
				_chunkVertices = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("chunkIndices")] 
		public rendIndexBufferChunk ChunkIndices
		{
			get
			{
				if (_chunkIndices == null)
				{
					_chunkIndices = (rendIndexBufferChunk) CR2WTypeManager.Create("rendIndexBufferChunk", "chunkIndices", cr2w, this);
				}
				return _chunkIndices;
			}
			set
			{
				if (_chunkIndices == value)
				{
					return;
				}
				_chunkIndices = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("numVertices")] 
		public CUInt16 NumVertices
		{
			get
			{
				if (_numVertices == null)
				{
					_numVertices = (CUInt16) CR2WTypeManager.Create("Uint16", "numVertices", cr2w, this);
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

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("materialId")] 
		public CArray<CName> MaterialId
		{
			get
			{
				if (_materialId == null)
				{
					_materialId = (CArray<CName>) CR2WTypeManager.Create("array:CName", "materialId", cr2w, this);
				}
				return _materialId;
			}
			set
			{
				if (_materialId == value)
				{
					return;
				}
				_materialId = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("vertexFactory")] 
		public CUInt8 VertexFactory
		{
			get
			{
				if (_vertexFactory == null)
				{
					_vertexFactory = (CUInt8) CR2WTypeManager.Create("Uint8", "vertexFactory", cr2w, this);
				}
				return _vertexFactory;
			}
			set
			{
				if (_vertexFactory == value)
				{
					return;
				}
				_vertexFactory = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("baseRenderMask")] 
		public CUInt16 BaseRenderMask
		{
			get
			{
				if (_baseRenderMask == null)
				{
					_baseRenderMask = (CUInt16) CR2WTypeManager.Create("Uint16", "baseRenderMask", cr2w, this);
				}
				return _baseRenderMask;
			}
			set
			{
				if (_baseRenderMask == value)
				{
					return;
				}
				_baseRenderMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("mergedRenderMask")] 
		public CUInt16 MergedRenderMask
		{
			get
			{
				if (_mergedRenderMask == null)
				{
					_mergedRenderMask = (CUInt16) CR2WTypeManager.Create("Uint16", "mergedRenderMask", cr2w, this);
				}
				return _mergedRenderMask;
			}
			set
			{
				if (_mergedRenderMask == value)
				{
					return;
				}
				_mergedRenderMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("renderMask")] 
		public CEnum<EMeshChunkFlags> RenderMask
		{
			get
			{
				if (_renderMask == null)
				{
					_renderMask = (CEnum<EMeshChunkFlags>) CR2WTypeManager.Create("EMeshChunkFlags", "renderMask", cr2w, this);
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

		[Ordinal(9)] 
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

		public rendChunk(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
